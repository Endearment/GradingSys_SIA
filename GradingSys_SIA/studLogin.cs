using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradingSys_SIA.Helpers;
using MySql.Data.MySqlClient;

namespace GradingSys_SIA
{
    public partial class studLogin : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=cis_db";
        public studLogin()
        {
            InitializeComponent();
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            txtCadetNumber.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string cadetNumber = txtCadetNumber.Text.Trim();

            if (string.IsNullOrEmpty(cadetNumber))
            {
                MessageBox.Show("Please enter your Cadet Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cadet_info WHERE cadet_id = @cadetNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cadetNumber", cadetNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sideBarPanel sideBar = new sideBarPanel(cadetNumber);
                                sideBar.Show();
                                this.Hide();
                            }
                            else
                            {
                                
                                MessageBox.Show("Cadet Number not found. Please check your input.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
