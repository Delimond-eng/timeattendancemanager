namespace TimeAttendaceSoftByGTech
{
    partial class EnrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollForm));
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gbInfoAgent = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPostnom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.gbInfoAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(12, 35);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(423, 30);
            this.textSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veullez entrer le matricule de l\'agent à enroller !";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSearch.Location = new System.Drawing.Point(441, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 30);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // gbInfoAgent
            // 
            this.gbInfoAgent.Controls.Add(this.buttonEnroll);
            this.gbInfoAgent.Controls.Add(this.labelPrenom);
            this.gbInfoAgent.Controls.Add(this.labelPostnom);
            this.gbInfoAgent.Controls.Add(this.labelNom);
            this.gbInfoAgent.Controls.Add(this.labelMatricule);
            this.gbInfoAgent.Controls.Add(this.label5);
            this.gbInfoAgent.Controls.Add(this.label4);
            this.gbInfoAgent.Controls.Add(this.label3);
            this.gbInfoAgent.Controls.Add(this.label2);
            this.gbInfoAgent.Controls.Add(this.pictureBox1);
            this.gbInfoAgent.Location = new System.Drawing.Point(12, 83);
            this.gbInfoAgent.Name = "gbInfoAgent";
            this.gbInfoAgent.Size = new System.Drawing.Size(539, 222);
            this.gbInfoAgent.TabIndex = 7;
            this.gbInfoAgent.TabStop = false;
            this.gbInfoAgent.Text = "Agent pointé informations";
            this.gbInfoAgent.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postnom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricule.Location = new System.Drawing.Point(248, 33);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(0, 20);
            this.labelMatricule.TabIndex = 5;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(248, 71);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 20);
            this.labelNom.TabIndex = 6;
            // 
            // labelPostnom
            // 
            this.labelPostnom.AutoSize = true;
            this.labelPostnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostnom.Location = new System.Drawing.Point(248, 109);
            this.labelPostnom.Name = "labelPostnom";
            this.labelPostnom.Size = new System.Drawing.Size(0, 20);
            this.labelPostnom.TabIndex = 7;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(248, 147);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(0, 20);
            this.labelPrenom.TabIndex = 8;
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.BackColor = System.Drawing.Color.Teal;
            this.buttonEnroll.FlatAppearance.BorderSize = 0;
            this.buttonEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnroll.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonEnroll.Location = new System.Drawing.Point(23, 179);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(498, 30);
            this.buttonEnroll.TabIndex = 8;
            this.buttonEnroll.Text = "Lancer l\'enrollement";
            this.buttonEnroll.UseVisualStyleBackColor = false;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 317);
            this.Controls.Add(this.gbInfoAgent);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.MinimizeBox = false;
            this.Name = "EnrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollement Agent";
            this.gbInfoAgent.ResumeLayout(false);
            this.gbInfoAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox gbInfoAgent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelPostnom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Button buttonEnroll;
    }
}