using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TimeAttendaceSoftByGTech.Kernel
{
    class DatabaseHelper
    {
        public string DatabaseFile { get; }

        public DatabaseHelper(string databaseFile)
        {
            DatabaseFile = databaseFile;
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            if (!System.IO.File.Exists(DatabaseFile))
            {
                SQLiteConnection.CreateFile(DatabaseFile);

                using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
                {
                    connection.Open();
                    string createApiAgentsTableQuery = @"
                    CREATE TABLE api_agents (
                        id INTEGER PRIMARY KEY,
                        agent_id TEXT UNIQUE,
                        matricule TEXT UNIQUE,
                        nom TEXT,
                        postnom TEXT,
                        prenom TEXT
                    )";
                    using (var command = new SQLiteCommand(createApiAgentsTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    string createFpAgentsTableQuery = @"
                    CREATE TABLE fp_agents (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        agent_id TEXT UNIQUE,
                        FpTemplate1 BLOB,
                        FpTemplate2 BLOB,
                        FpTemplate3 BLOB
                    )";
                    using (var command = new SQLiteCommand(createFpAgentsTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }


        public bool AddMockData()
        {
            List<Agent> datas = new List<Agent>
            {
                new Agent("02", "0AB2", "Gaston", "Delimond", "Bobby"),
                new Agent("03", "0AB3", "Laurent", "Bukasa", "Tshitoko"),
                new Agent("04", "0AB4", "Kabemba", "Landry", "Nyota"),
                new Agent("05", "0AB5", "Lionnel", "Nawej", "Kayembe"),
                new Agent("06", "0AB6", "Florence", "Nyonga", "Kalala"),
                new Agent("07", "0AB7", "Ngongo", "Kasongo", "Giresse")
            };

            foreach (var agent in datas)
            {
                AddOrUpdateApiAgent(agent.AgentId, agent.Matricule, agent.Nom, agent.Postnom, agent.Prenom);
            }

            return true;
        }

        public void AddOrUpdateApiAgent(string agentId, string matricule, string nom, string postnom, string prenom)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM api_agents WHERE matricule = @Matricule";
                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Matricule", matricule);
                    long count = (long)selectCommand.ExecuteScalar();

                    string insertOrUpdateQuery = count > 0
                        ? "UPDATE api_agents SET agent_id=@AgentId, nom=@Nom, postnom=@Postnom, prenom=@Prenom WHERE matricule = @Matricule"
                        : "INSERT INTO api_agents (agent_id, matricule, nom, postnom, prenom) VALUES (@AgentId,@Matricule,@Nom,@Postnom,@Prenom)";

                    using (var command = new SQLiteCommand(insertOrUpdateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AgentId", agentId);
                        command.Parameters.AddWithValue("@Matricule", matricule);
                        command.Parameters.AddWithValue("@Nom", nom);
                        command.Parameters.AddWithValue("@Postnom", postnom);
                        command.Parameters.AddWithValue("@Prenom", prenom);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public Agent GetAgentByMatricule(string matricule)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM api_agents WHERE matricule = @Matricule";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Matricule", matricule);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string agentId = reader["agent_id"].ToString();
                            string mat = reader["matricule"].ToString();
                            string nom = reader["nom"].ToString();
                            string postnom = reader["postnom"].ToString();
                            string prenom = reader["prenom"].ToString();

                            return new Agent(agentId, mat, nom, postnom, prenom);
                        }
                    }
                }
            }
            return null;
        }


        public Agent GetAgentById(string agent_id)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM api_agents WHERE agent_id = @AgentId";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@AgentId", agent_id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string agentId = reader["agent_id"].ToString();
                            string matricule = reader["matricule"].ToString();
                            string nom = reader["nom"].ToString();
                            string postnom = reader["postnom"].ToString();
                            string prenom = reader["prenom"].ToString();

                            return new Agent(agentId, matricule, nom, postnom, prenom);
                        }
                    }
                }
            }
            return null;
        }

        public string GetApiAgentIdByMatricule(string matricule)
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id FROM api_agents WHERE Matricule = @Matricule";
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Matricule", matricule);
                        var result = command.ExecuteScalar();
                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine($"An error occurred while retrieving the agent ID: {ex.Message}");
                return null;
            }
        }

        public void AddFpAgent(string apiAgentId, byte[] template1, byte[] template2, byte[] template3)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                connection.Open();
                string insertQuery = "INSERT INTO fp_agents(agent_id, FpTemplate1, FpTemplate2, FpTemplate3) VALUES (@ApiAgentId, @FpTemplate1, @FpTemplate2, @FpTemplate3)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ApiAgentId", apiAgentId);
                    command.Parameters.AddWithValue("@FpTemplate1", template1);
                    command.Parameters.AddWithValue("@FpTemplate2", template2);
                    command.Parameters.AddWithValue("@FpTemplate3", template3);
                    command.ExecuteNonQuery();
                }
            }
        }

        public SQLiteDataReader GetAllFpAgents()
        {
            var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;");
            connection.Open();
            string selectQuery = "SELECT * FROM fp_agents";
            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                return command.ExecuteReader();
            }
        }
    }

    public class Agent
    {
        public string AgentId { get; set; }

        public string Matricule { get; set; }

        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }

        public Agent(string agentId, string matricule,string nom, string postnom, string prenom)
        {
            AgentId = agentId;
            Matricule = matricule;
            Nom = nom;
            Matricule = matricule;
            Postnom = postnom;
            Prenom = prenom;
        }


        public override string ToString()
        {
            return $"**{Matricule}** {Nom} {Postnom} {Prenom}";
        }
    }
}
