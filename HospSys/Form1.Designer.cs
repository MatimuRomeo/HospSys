namespace HospSys
{
    partial class Form1
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.comboBoxHomeUserNames = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxHomePassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlForgotPass = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHomeHavingTroubleAnswer = new System.Windows.Forms.TextBox();
            this.labelHomeHavingTroubleQuestion = new System.Windows.Forms.Label();
            this.comboBoxHomeHavingTroubleUserName = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlForgotPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlTop.Controls.Add(this.comboBoxHomeUserNames);
            this.pnlTop.Controls.Add(this.linkLabel1);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.textBoxHomePassword);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 97);
            this.pnlTop.TabIndex = 0;
            // 
            // comboBoxHomeUserNames
            // 
            this.comboBoxHomeUserNames.FormattingEnabled = true;
            this.comboBoxHomeUserNames.Location = new System.Drawing.Point(142, 37);
            this.comboBoxHomeUserNames.Name = "comboBoxHomeUserNames";
            this.comboBoxHomeUserNames.Size = new System.Drawing.Size(265, 21);
            this.comboBoxHomeUserNames.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(424, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Having trouble?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(420, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxHomePassword
            // 
            this.textBoxHomePassword.Location = new System.Drawing.Point(424, 37);
            this.textBoxHomePassword.Name = "textBoxHomePassword";
            this.textBoxHomePassword.PasswordChar = '•';
            this.textBoxHomePassword.Size = new System.Drawing.Size(243, 20);
            this.textBoxHomePassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HospSys.Properties.Resources.FontAwesome_f011_0__256;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(900, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pnlForgotPass);
            this.panel1.Controls.Add(this.pnlPic);
            this.panel1.Location = new System.Drawing.Point(13, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 503);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::HospSys.Properties.Resources.hospital;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(377, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(594, 497);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pnlForgotPass
            // 
            this.pnlForgotPass.Controls.Add(this.button2);
            this.pnlForgotPass.Controls.Add(this.textBoxHomeHavingTroubleAnswer);
            this.pnlForgotPass.Controls.Add(this.labelHomeHavingTroubleQuestion);
            this.pnlForgotPass.Controls.Add(this.comboBoxHomeHavingTroubleUserName);
            this.pnlForgotPass.Controls.Add(this.pictureBox5);
            this.pnlForgotPass.Location = new System.Drawing.Point(34, 37);
            this.pnlForgotPass.Name = "pnlForgotPass";
            this.pnlForgotPass.Size = new System.Drawing.Size(337, 414);
            this.pnlForgotPass.TabIndex = 4;
            this.pnlForgotPass.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxHomeHavingTroubleAnswer
            // 
            this.textBoxHomeHavingTroubleAnswer.Location = new System.Drawing.Point(19, 312);
            this.textBoxHomeHavingTroubleAnswer.Name = "textBoxHomeHavingTroubleAnswer";
            this.textBoxHomeHavingTroubleAnswer.Size = new System.Drawing.Size(265, 20);
            this.textBoxHomeHavingTroubleAnswer.TabIndex = 3;
            // 
            // labelHomeHavingTroubleQuestion
            // 
            this.labelHomeHavingTroubleQuestion.AutoSize = true;
            this.labelHomeHavingTroubleQuestion.Location = new System.Drawing.Point(19, 281);
            this.labelHomeHavingTroubleQuestion.Name = "labelHomeHavingTroubleQuestion";
            this.labelHomeHavingTroubleQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelHomeHavingTroubleQuestion.TabIndex = 2;
            this.labelHomeHavingTroubleQuestion.Text = "label3";
            // 
            // comboBoxHomeHavingTroubleUserName
            // 
            this.comboBoxHomeHavingTroubleUserName.FormattingEnabled = true;
            this.comboBoxHomeHavingTroubleUserName.Location = new System.Drawing.Point(19, 244);
            this.comboBoxHomeHavingTroubleUserName.Name = "comboBoxHomeHavingTroubleUserName";
            this.comboBoxHomeHavingTroubleUserName.Size = new System.Drawing.Size(265, 21);
            this.comboBoxHomeHavingTroubleUserName.TabIndex = 1;
            this.comboBoxHomeHavingTroubleUserName.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeHavingTroubleUserName_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::HospSys.Properties.Resources.User;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(59, 58);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(183, 171);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pnlPic
            // 
            this.pnlPic.Controls.Add(this.pictureBox2);
            this.pnlPic.Location = new System.Drawing.Point(34, 37);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(308, 414);
            this.pnlPic.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HospSys.Properties.Resources.ptech;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(32, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 203);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::HospSys.Properties.Resources.Copyright;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(540, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(403, 46);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlForgotPass.ResumeLayout(false);
            this.pnlForgotPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxHomePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.Panel pnlForgotPass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxHomeHavingTroubleAnswer;
        private System.Windows.Forms.Label labelHomeHavingTroubleQuestion;
        private System.Windows.Forms.ComboBox comboBoxHomeHavingTroubleUserName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBoxHomeUserNames;
    }
}

