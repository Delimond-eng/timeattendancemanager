using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeAttendaceSoftByGTech.Kernel
{
    class FingerprintManager
    {
        public DatabaseHelper _db;

        public FingerprintManager(string databaseFile)
        {
            _db = new DatabaseHelper(databaseFile);
        }

        public bool EnrollAgent(string apiAgentId)
        {
            if (FPutils_x64.FPModule_OpenDevice() != 0)
            {
                return false;
            }
            FPModule_SetCollectTimes(3);
            byte[] template1 = new byte[512];
            byte[] template2 = new byte[512];
            byte[] template3 = new byte[512];

            int result = FPutils_x64.FPModule_FpEnroll(template1);
            if (result != 0) return false;

            result = FPutils_x64.FPModule_FpEnroll(template2);
            if (result != 0) return false;

            result = FPutils_x64.FPModule_FpEnroll(template3);
            if (result != 0) return false;

            _db.AddFpAgent(apiAgentId, template1, template2, template3);
            return true;
        }

        public string IdentifyAgent()
        {
            if (FPutils_x64.FPModule_OpenDevice() != 0)
            {
                MessageBox.Show("Impossible de detecter l'empreinte car le dispositif n'est pas connecté !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            byte[] capturedTemplate = new byte[512];
           
            int result = FPutils_x64.FPModule_FpEnroll(capturedTemplate);
            if (result != 0) return null;

            int securityLevel = 3; // You can adjust the security level as needed

            using (var reader = _db.GetAllFpAgents())
            {
                while (reader.Read())
                {
                    byte[] dbTemplate1 = (byte[])reader["FpTemplate1"];
                    byte[] dbTemplate2 = (byte[])reader["FpTemplate2"];
                    byte[] dbTemplate3 = (byte[])reader["FpTemplate3"];

                    if (FPutils_x64.FPModule_MatchTemplate(capturedTemplate, dbTemplate1, securityLevel) == 0 ||
                        FPutils_x64.FPModule_MatchTemplate(capturedTemplate, dbTemplate2, securityLevel) == 0 ||
                        FPutils_x64.FPModule_MatchTemplate(capturedTemplate, dbTemplate3, securityLevel) == 0)
                    {
                        return reader["agent_id"].ToString();
                    }
                }
            }
            return null;
        }


        public async Task<string> MonitorFingerprintAsync()
        {
            FPutils_x64.FPModule_SetCollectTimes(1);
            while (true)
            {
                int fpStatus = 0;
                int result = FPutils_x64.FPModule_DetectFinger(ref fpStatus);

                if (result == 0 && fpStatus == 1)
                {
                    string identifiedAgentId = IdentifyAgent();
                    if (identifiedAgentId != null)
                    {
                        return identifiedAgentId;
                    }
                    else
                    {
                        return null;
                    }
                }
                await Task.Delay(500);
            }
        }


        private async Task SignalPresenceAsync(string agentId)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://yourserver.com/api/signal_presence?agent_id={agentId}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Presence signaled for Agent ID: {agentId}");
                }
                else
                {
                    Console.WriteLine($"Failed to signal presence for Agent ID: {agentId}");
                }
            }
        }

        public static int FPModule_SetCollectTimes(int dwTimes)
        {
            return FPutils_x64.FPModule_SetCollectTimes(dwTimes);
        }
    }

}
