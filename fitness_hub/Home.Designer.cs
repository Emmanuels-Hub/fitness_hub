namespace fitness_hub
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            setCal = new Button();
            getCal = new TextBox();
            calData = new Label();
            runPage = new Button();
            sprintPage = new Button();
            cycPage = new Button();
            jumPage = new Button();
            yogaPage = new Button();
            swimPage = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(setCal);
            panel1.Controls.Add(getCal);
            panel1.Controls.Add(calData);
            panel1.Controls.Add(runPage);
            panel1.Controls.Add(sprintPage);
            panel1.Controls.Add(cycPage);
            panel1.Controls.Add(jumPage);
            panel1.Controls.Add(yogaPage);
            panel1.Controls.Add(swimPage);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 401);
            panel1.TabIndex = 0;
            // 
            // setCal
            // 
            setCal.BackColor = Color.Maroon;
            setCal.FlatStyle = FlatStyle.Popup;
            setCal.ForeColor = Color.White;
            setCal.Location = new Point(272, 88);
            setCal.Name = "setCal";
            setCal.Size = new Size(121, 38);
            setCal.TabIndex = 13;
            setCal.Text = "Set Calory";
            setCal.UseVisualStyleBackColor = false;
            setCal.Click += setCal_Click;
            // 
            // getCal
            // 
            getCal.Location = new Point(26, 97);
            getCal.Name = "getCal";
            getCal.PlaceholderText = "Set your Calory Limit";
            getCal.Size = new Size(225, 29);
            getCal.TabIndex = 12;
            // 
            // calData
            // 
            calData.AutoSize = true;
            calData.Font = new Font("Castellar", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calData.Location = new Point(162, 164);
            calData.Name = "calData";
            calData.Size = new Size(99, 34);
            calData.TabIndex = 10;
            calData.Text = "0000";
            calData.Click += calData_Click;
            // 
            // runPage
            // 
            runPage.BackColor = Color.Maroon;
            runPage.FlatStyle = FlatStyle.Popup;
            runPage.ForeColor = Color.White;
            runPage.Location = new Point(303, 312);
            runPage.Name = "runPage";
            runPage.Size = new Size(121, 47);
            runPage.TabIndex = 9;
            runPage.Text = "Running";
            runPage.UseVisualStyleBackColor = false;
            runPage.Click += runPage_Click;
            // 
            // sprintPage
            // 
            sprintPage.BackColor = Color.Maroon;
            sprintPage.FlatStyle = FlatStyle.Popup;
            sprintPage.ForeColor = Color.White;
            sprintPage.Location = new Point(162, 312);
            sprintPage.Name = "sprintPage";
            sprintPage.Size = new Size(121, 47);
            sprintPage.TabIndex = 8;
            sprintPage.Text = "Sprint";
            sprintPage.UseVisualStyleBackColor = false;
            sprintPage.Click += sprintPage_Click;
            // 
            // cycPage
            // 
            cycPage.BackColor = Color.Maroon;
            cycPage.FlatStyle = FlatStyle.Popup;
            cycPage.ForeColor = Color.White;
            cycPage.Location = new Point(26, 312);
            cycPage.Name = "cycPage";
            cycPage.Size = new Size(121, 47);
            cycPage.TabIndex = 7;
            cycPage.Text = "Cycling";
            cycPage.UseVisualStyleBackColor = false;
            cycPage.Click += cycPage_Click;
            // 
            // jumPage
            // 
            jumPage.BackColor = Color.Maroon;
            jumPage.FlatStyle = FlatStyle.Popup;
            jumPage.ForeColor = Color.White;
            jumPage.Location = new Point(303, 234);
            jumPage.Name = "jumPage";
            jumPage.Size = new Size(121, 47);
            jumPage.TabIndex = 6;
            jumPage.Text = "Jumpimg";
            jumPage.UseVisualStyleBackColor = false;
            jumPage.Click += jumPage_Click;
            // 
            // yogaPage
            // 
            yogaPage.BackColor = Color.Maroon;
            yogaPage.FlatStyle = FlatStyle.Popup;
            yogaPage.ForeColor = Color.White;
            yogaPage.Location = new Point(162, 234);
            yogaPage.Name = "yogaPage";
            yogaPage.Size = new Size(121, 47);
            yogaPage.TabIndex = 5;
            yogaPage.Text = "Yoga";
            yogaPage.UseVisualStyleBackColor = false;
            yogaPage.Click += yogaPage_Click;
            // 
            // swimPage
            // 
            swimPage.BackColor = Color.Maroon;
            swimPage.FlatStyle = FlatStyle.Popup;
            swimPage.ForeColor = Color.White;
            swimPage.Location = new Point(26, 234);
            swimPage.Name = "swimPage";
            swimPage.Size = new Size(121, 47);
            swimPage.TabIndex = 4;
            swimPage.Text = "Swimming";
            swimPage.UseVisualStyleBackColor = false;
            swimPage.Click += swimPage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 16F);
            label1.Location = new Point(60, 10);
            label1.Name = "label1";
            label1.Size = new Size(333, 35);
            label1.TabIndex = 14;
            label1.Text = "Welcome to Fitness Hub";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 414);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button swimPage;
        private TextBox getCal;
        private Label calData;
        private Button runPage;
        private Button sprintPage;
        private Button cycPage;
        private Button jumPage;
        private Button yogaPage;
        private Button setCal;
        private Label label1;
    }
}