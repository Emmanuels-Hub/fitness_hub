namespace fitness_hub
{
    partial class Login
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
            panel1 = new Panel();
            regPage = new LinkLabel();
            label2 = new Label();
            submitbtn = new Button();
            getlogpass = new TextBox();
            getloguser = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(regPage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(submitbtn);
            panel1.Controls.Add(getlogpass);
            panel1.Controls.Add(getloguser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 366);
            panel1.TabIndex = 0;
            // 
            // regPage
            // 
            regPage.AutoSize = true;
            regPage.Font = new Font("Berlin Sans FB", 13F);
            regPage.LinkColor = Color.Red;
            regPage.Location = new Point(240, 299);
            regPage.Name = "regPage";
            regPage.Size = new Size(94, 29);
            regPage.TabIndex = 5;
            regPage.TabStop = true;
            regPage.Text = "Sign up";
            regPage.LinkClicked += regPage_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 305);
            label2.Name = "label2";
            label2.Size = new Size(207, 23);
            label2.TabIndex = 4;
            label2.Text = "Don't have an Account?";
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Maroon;
            submitbtn.FlatStyle = FlatStyle.Popup;
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(56, 217);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(255, 34);
            submitbtn.TabIndex = 3;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // getlogpass
            // 
            getlogpass.Location = new Point(56, 156);
            getlogpass.Name = "getlogpass";
            getlogpass.PasswordChar = '*';
            getlogpass.PlaceholderText = "Enter password";
            getlogpass.Size = new Size(255, 29);
            getlogpass.TabIndex = 2;
            // 
            // getloguser
            // 
            getloguser.Location = new Point(56, 111);
            getloguser.Name = "getloguser";
            getloguser.PlaceholderText = "Enter username";
            getloguser.Size = new Size(255, 29);
            getloguser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(309, 35);
            label1.TabIndex = 0;
            label1.Text = "Login to your Account";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(436, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 366);
            panel2.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 98);
            label4.Name = "label4";
            label4.Size = new Size(184, 23);
            label4.TabIndex = 1;
            label4.Text = "Sweat, Smile, Repeat";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 190);
            label6.Name = "label6";
            label6.Size = new Size(195, 23);
            label6.TabIndex = 3;
            label6.Text = "Get moving, feel alive.";
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 414);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel regPage;
        private Label label2;
        private Button submitbtn;
        private TextBox getlogpass;
        private TextBox getloguser;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}