namespace fitness_hub
{
    partial class Running
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Running));
            goHome = new Button();
            panel1 = new Panel();
            getWeight = new TextBox();
            getTime = new TextBox();
            label1 = new Label();
            calculate = new Button();
            getDis = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // goHome
            // 
            goHome.BackColor = Color.Maroon;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(14, 8);
            goHome.Name = "goHome";
            goHome.Size = new Size(78, 32);
            goHome.TabIndex = 15;
            goHome.Text = "Back";
            goHome.UseVisualStyleBackColor = false;
            goHome.Click += goHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(getWeight);
            panel1.Controls.Add(getTime);
            panel1.Controls.Add(goHome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(calculate);
            panel1.Controls.Add(getDis);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 401);
            panel1.TabIndex = 4;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(105, 177);
            getWeight.Name = "getWeight";
            getWeight.PlaceholderText = "Weight(kg)";
            getWeight.Size = new Size(225, 29);
            getWeight.TabIndex = 17;
            // 
            // getTime
            // 
            getTime.Location = new Point(105, 244);
            getTime.Name = "getTime";
            getTime.PlaceholderText = "Time(s)";
            getTime.Size = new Size(225, 29);
            getTime.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 16F);
            label1.Location = new Point(69, 59);
            label1.Name = "label1";
            label1.Size = new Size(333, 35);
            label1.TabIndex = 14;
            label1.Text = "Welcome to Fitness Hub";
            // 
            // calculate
            // 
            calculate.BackColor = Color.Maroon;
            calculate.FlatStyle = FlatStyle.Popup;
            calculate.ForeColor = Color.White;
            calculate.Location = new Point(151, 318);
            calculate.Name = "calculate";
            calculate.Size = new Size(121, 38);
            calculate.TabIndex = 13;
            calculate.Text = "Check";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // getDis
            // 
            getDis.Location = new Point(105, 124);
            getDis.Name = "getDis";
            getDis.PlaceholderText = "Distance(m)";
            getDis.Size = new Size(225, 29);
            getDis.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Running
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 414);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Running";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Running";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goHome;
        private Panel panel1;
        private TextBox getWeight;
        private TextBox getTime;
        private Label label1;
        private Button calculate;
        private TextBox getDis;
        private PictureBox pictureBox1;
    }
}