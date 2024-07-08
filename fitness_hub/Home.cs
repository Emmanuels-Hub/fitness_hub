using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_hub
{
    public partial class Home : Form
    {
        private string connectionString = "Data Source=fitdatabase.db;Version=3;";
        public Home()
        {
            InitializeComponent();
        }

        private void calData_Click(object sender, EventArgs e)
        {

        }

        private void setCal_Click(object sender, EventArgs e)
        {
            int calo;
            bool isValid = int.TryParse(getCal.Text, out calo);
            if (getCal.Text != "")
            {
                if (isValid)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string insertDataQuery = "INSERT INTO calory (id, value) VALUES (1, @cal) ON CONFLICT(id) DO UPDATE SET value = excluded.value;";
                        using (SQLiteCommand cmd = new SQLiteCommand(insertDataQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@cal", getCal.Text);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                    MessageBox.Show("Calory Set to: " + getCal.Text, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    calData.Text = getCal.Text;
                }
                else
                {
                    MessageBox.Show("Input Field must be Number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Input Field cannot be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string selectDataQuery = "SELECT value FROM calory WHERE id = 1 ";
                using (SQLiteCommand cmd = new SQLiteCommand(selectDataQuery, conn))
                {
                    object fetchedData = cmd.ExecuteScalar();
                    if (fetchedData != null)
                    {
                        string data = fetchedData.ToString();
                        calData.Text = data;
                    }
                    else
                    {
                        calData.Text = "0";
                    }

                }

                conn.Close();
            }

        }

        private void swimPage_Click(object sender, EventArgs e)
        {
            new Swimming().Show();
            this.Hide();
        }

        private void yogaPage_Click(object sender, EventArgs e)
        {
            new Yoga().Show();
            this.Hide();
        }

        private void jumPage_Click(object sender, EventArgs e)
        {
            new Jumping().Show();
            this.Hide();
        }

        private void runPage_Click(object sender, EventArgs e)
        {
            new Running().Show();
            this.Hide();
        }

        private void sprintPage_Click(object sender, EventArgs e)
        {
            new Sprint().Show();
            this.Hide();
        }

        private void cycPage_Click(object sender, EventArgs e)
        {
            new Cycling().Show();
            this.Hide();
        }
    }
}
