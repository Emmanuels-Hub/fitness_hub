namespace fitness_hub
{
    partial class Jumping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jumping));
            goHome = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            levelInt = new NumericUpDown();
            getWeight = new TextBox();
            getDur = new TextBox();
            label1 = new Label();
            calculate = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).BeginInit();
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(levelInt);
            panel1.Controls.Add(getWeight);
            panel1.Controls.Add(getDur);
            panel1.Controls.Add(goHome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(calculate);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 401);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 260);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 21;
            label4.Text = "Duration";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 192);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 20;
            label3.Text = "Weight(kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 115);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 19;
            label2.Text = "Intensity";
            // 
            // levelInt
            // 
            levelInt.Location = new Point(105, 142);
            levelInt.Name = "levelInt";
            levelInt.Size = new Size(225, 29);
            levelInt.TabIndex = 18;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(107, 218);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(225, 29);
            getWeight.TabIndex = 17;
            // 
            // getDur
            // 
            getDur.Location = new Point(107, 286);
            getDur.Name = "getDur";
            getDur.Size = new Size(225, 29);
            getDur.TabIndex = 16;
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
            calculate.Location = new Point(151, 336);
            calculate.Name = "calculate";
            calculate.Size = new Size(121, 38);
            calculate.TabIndex = 13;
            calculate.Text = "Check";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
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
            // Jumping
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 414);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Jumping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jumping";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goHome;
        private Panel panel1;
        private TextBox getWeight;
        private TextBox getDur;
        private Label label1;
        private Button calculate;
        private PictureBox pictureBox1;
        private NumericUpDown levelInt;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}