using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormLogin : Form
    {
        DB DB = new DB();

        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void Login()
        {
            string login = textbox_login.Text;
            string password = textbox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"SELECT login, password from table_login where login = '{login}' and password = '{password}'";

                SqlCommand com = new SqlCommand(querystring, DB.GetConnection());
                adapter.SelectCommand = com;
                adapter.Fill(table);

     
                       
                        if (table.Rows.Count > 0) 
                        {
                            textbox_login.Text = "";
                            textbox_password.Text = "";
                            FormMenu formMenu = new FormMenu();
                            formMenu.Closed += (s, args) => this.Close();
                            this.Hide();
                            formMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Такого аккаунта не существует");
                        }
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
