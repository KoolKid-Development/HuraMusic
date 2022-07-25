using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HuraMusic
{
    
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string usernames;
        Authentication auth;
        public static string accountname;
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty)
            {
                checkAccount(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("You need to fill in your info!");
            }
        }
        private void checkAccount(string username, string password)
        {
            auth = new Authentication();
            auth.getConnection();

            using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                string query = @"SELECT * FROM Conturi WHERE Username='" + username + "' and Password= '" + password + "'";
                int count = 0;
                cmd.CommandText = query;
                cmd.Connection = con;

                SQLiteDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("You are now logged in!");
                    usernames = username;
                    accountname = txtUsername.Text;
                    FrmHome succes = new FrmHome();
                    succes.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Is Wrong!");
                    return;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
