namespace TimeAttendaceSoftByGTech
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des heures de présence ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(320, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enroller un nouveau agent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.pictureBox1);
            this.gbInfo.Location = new System.Drawing.Point(24, 136);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(564, 184);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Agent pointé informations";
            this.gbInfo.Visible = false;
            this.gbInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postnom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.label6);
            this.gbMessage.Enabled = false;
            this.gbMessage.Location = new System.Drawing.Point(30, 149);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(564, 151);
            this.gbMessage.TabIndex = 8;
            this.gbMessage.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(30, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Charger les donnees des agents";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(480, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Veuillez poser votre empreinte sur le terminal pour pointer votre présence !";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 339);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMessage);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}