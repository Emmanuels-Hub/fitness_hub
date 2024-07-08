using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace fitness_hub
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=fitdatabase.db;Version=3;";

        public Register()
        {
            InitializeComponent();
            InitializeDatabase();

        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Create a table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)";
                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create a table if it doesn't exist
                string createCalQuery = "CREATE TABLE IF NOT EXISTS calory (id INTEGER PRIMARY KEY CHECK (id = 1), value INTEGER NOT NULL )";
                using (SQLiteCommand cmd = new SQLiteCommand(createCalQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public bool valpass(string password)
        {
            var uppercase = new Regex(@"[A-Z]+");
            var lowercase = new Regex(@"[a-z]+");

            if (uppercase.IsMatch(password) && lowercase.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (getuser.Text == "" && getpass.Text == "" && getcompass.Text == "")
            {
                MessageBox.Show("Input fields cannot be Empty.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (getcompass.Text == getpass.Text)
            {
                if (getpass.TextLength >= 12)
                {
                    if (valpass(getpass.Text) == true)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();

                            string insertDataQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                            using (SQLiteCommand cmd = new SQLiteCommand(insertDataQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", getuser.Text);
                                cmd.Parameters.AddWithValue("@password", getpass.Text);
                                cmd.ExecuteNonQuery();
                            }

                            conn.Close();
                        }

                        MessageBox.Show("Account Created Successful.", "Created.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password must contain at least 1 lowercase and 1 uppercase letter", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password lenght must be Above 12.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Password Doesn't Match.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getpass.Text = "";
                getcompass.Text = "";
                getpass.Focus();
            }
        }

        private void logPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
