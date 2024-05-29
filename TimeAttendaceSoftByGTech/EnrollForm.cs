using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeAttendaceSoftByGTech.Kernel;

namespace TimeAttendaceSoftByGTech
{
    public partial class EnrollForm : Form
    {
       private Agent _agent;
        public EnrollForm()
        {
            InitializeComponent();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searcher = textSearch.Text;
            if(searcher == "")
            {
                MessageBox.Show("Veuillez saisir le matricule de l'agent !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var agent = new DatabaseHelper("fp_database.db").GetAgentByMatricule(searcher);

            if(agent != null)
            {
                gbInfoAgent.Visible = true;
                this._agent = agent;
                labelMatricule.Text = agent.Matricule;
                labelNom.Text = agent.Nom;
                labelPostnom.Text = agent.Postnom;
                labelPrenom.Text = agent.Prenom;
            }
            else
            {
                MessageBox.Show("Aucun agent trouvé dans le système !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            var isDone = new FingerprintManager("fp_database.db").EnrollAgent(this._agent.AgentId);

            if (isDone)
            {
                MessageBox.Show("Agent enrollé avec succès !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                gbInfoAgent.Visible = false;
                textSearch.Text = "";
                this._agent = null;
            }
            else
            {
                MessageBox.Show("Echec d'enrollement d'empreinte !", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
