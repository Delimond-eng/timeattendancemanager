using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeAttendaceSoftByGTech
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Username.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Veuillez entrer vos identifiant pour continuer !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Username.Text == "laurent@gmail.com" && Password.Text == "12345")
            {
                this.Hide();
                new MainScreen().Show();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe erroné !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
