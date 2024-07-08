namespace fitness_hub
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            getcompass = new TextBox();
            logPage = new LinkLabel();
            label2 = new Label();
            submitbtn = new Button();
            getpass = new TextBox();
            getuser = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(getcompass);
            panel1.Controls.Add(logPage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(submitbtn);
            panel1.Controls.Add(getpass);
            panel1.Controls.Add(getuser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 366);
            panel1.TabIndex = 2;
            // 
            // getcompass
            // 
            getcompass.Location = new Point(56, 206);
            getcompass.Name = "getcompass";
            getcompass.PasswordChar = '*';
            getcompass.PlaceholderText = "Comfirm password";
            getcompass.Size = new Size(255, 29);
            getcompass.TabIndex = 6;
            // 
            // logPage
            // 
            logPage.AutoSize = true;
            logPage.Font = new Font("Berlin Sans FB", 13F);
            logPage.LinkColor = Color.Red;
            logPage.Location = new Point(262, 322);
            logPage.Name = "logPage";
            logPage.Size = new Size(84, 29);
            logPage.TabIndex = 5;
            logPage.TabStop = true;
            logPage.Text = "Sign in";
            logPage.LinkClicked += logPage_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 322);
            label2.Name = "label2";
            label2.Size = new Size(229, 23);
            label2.TabIndex = 4;
            label2.Text = "Already have an Account?";
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Maroon;
            submitbtn.FlatStyle = FlatStyle.Popup;
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(56, 262);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(255, 34);
            submitbtn.TabIndex = 3;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // getpass
            // 
            getpass.Location = new Point(56, 156);
            getpass.Name = "getpass";
            getpass.PasswordChar = '*';
            getpass.PlaceholderText = "Enter password";
            getpass.Size = new Size(255, 29);
            getpass.TabIndex = 2;
            // 
            // getuser
            // 
            getuser.Location = new Point(56, 111);
            getuser.Name = "getuser";
            getuser.PlaceholderText = "Enter username";
            getuser.Size = new Size(255, 29);
            getuser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(289, 35);
            label1.TabIndex = 0;
            label1.Text = "Create your Account";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(432, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 366);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 243);
            label7.Name = "label7";
            label7.Size = new Size(221, 23);
            label7.TabIndex = 4;
            label7.Text = "Train Hard, Stay Humble.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 190);
            label6.Name = "label6";
            label6.Size = new Size(195, 23);
            label6.TabIndex = 3;
            label6.Text = "Get moving, feel alive.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 140);
            label5.Name = "label5";
            label5.Size = new Size(222, 23);
            label5.TabIndex = 2;
            label5.Text = "Strong Body, Strong Mind.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 98);
            label4.Name = "label4";
            label4.Size = new Size(184, 23);
            label4.TabIndex = 1;
            label4.Text = "Sweat, Smile, Repeat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 13F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(415, 29);
            label3.TabIndex = 0;
            label3.Text = "Here are tips to help you get started.";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 414);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox getcompass;
        private LinkLabel logPage;
        private Label label2;
        private Button submitbtn;
        private TextBox getpass;
        private TextBox getuser;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
