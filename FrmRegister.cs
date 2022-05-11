using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HuraMusic
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        Authentication auth;

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty
                && txtConfirmPassword.Text != string.Empty
                && txtEmail.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    checkAccount(txtUsername.Text);
                }
            }
            else
            {
                MessageBox.Show("You need to fill in all your info!");
            }
        }
        private void checkAccount(string username)
        {
            auth = new Authentication();

            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();
                    int count = 0;
                    string query = @"SELECT * FROM Conturi WHERE Username='" + username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Account alerty registred!");
                    }
                    else if (count == 0)
                    {
                        insertData(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
        }
        private void insertData(string usernames, string password, string email)
        {
            auth = new Authentication();
            auth.getConnection();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"INSERT INTO Conturi(Username, Password, Email) VALUES(@username, @password, @email)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@username", usernames));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your account is now registred!");

                    FrmLogin a = new FrmLogin();
                    a.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            l.Show();
            this.Hide();
        }
    }
}
