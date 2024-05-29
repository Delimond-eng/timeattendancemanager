using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeAttendaceSoftByGTech.Kernel;

namespace TimeAttendaceSoftByGTech
{
    public partial class MainScreen : Form
    {
        private FingerprintManager fingerprintManager;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _fingerprintTask;
        string databaseFile = "fp_database.db";
        public MainScreen()
        {
            InitializeComponent();
            
            fingerprintManager = new FingerprintManager(databaseFile);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isDone = new DatabaseHelper("fp_database.db").AddMockData();
            FingerprintManager fpManager = new FingerprintManager("fp_database.db");
       
            if (isDone)
            {
                MessageBox.Show("Donnés mises à jour !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Echec de mises à jour!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          

            _cancellationTokenSource.Cancel();

            // Attendre que la tâche de détection se termine
            await _fingerprintTask;

            // Ouvrir le formulaire modal pour l'enrôlement
            using (var enrollmentForm = new EnrollForm())
            {
                enrollmentForm.ShowDialog();
            }

            // Redémarrer la détection d'empreintes digitales
            _cancellationTokenSource = new CancellationTokenSource();
            _fingerprintTask = runDectectFingers(_cancellationTokenSource.Token);
            await _fingerprintTask;
        }

        private async void MainScreen_Load(object sender, EventArgs e)
        {
           // await runDectectFingers();

            _cancellationTokenSource = new CancellationTokenSource();
            _fingerprintTask = runDectectFingers(_cancellationTokenSource.Token);
            await _fingerprintTask;

        }

        public async Task runDectectFingers(CancellationToken cancellationToken)
        {
            if (FPutils_x64.FPModule_OpenDevice() != 0)
            {
                MessageBox.Show("Echec de connecter le dispositif d'empreinte.");
                return;
            }

            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var identifiedAgentId = await fingerprintManager.MonitorFingerprintAsync();

                    if (identifiedAgentId != null)
                    {
                        var agent = new DatabaseHelper(databaseFile).GetAgentById(identifiedAgentId);
                        if (agent != null)
                        {
                            MessageBox.Show($"Bienvenue agent: {agent.ToString()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun agent trouvé.");
                        }
                        // Effectuer une action après avoir identifié l'agent
                    }
                    else
                    {
                        MessageBox.Show("Aucune correspondance d'empreinte trouvée.");
                    }

                    // Pause between scans to avoid continuous scanning
                    await Task.Delay(2000);
                }
            }
            finally
            {
                FPutils_x64.FPModule_CloseDevice();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
