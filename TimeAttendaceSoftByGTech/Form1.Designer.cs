namespace TimeAttendaceSoftByGTech
{
    partial class AuthForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(12, 32);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(384, 30);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(12, 88);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(384, 30);
            this.Password.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTHENTIFICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
    }
}

