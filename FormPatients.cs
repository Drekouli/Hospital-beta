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
    public partial class FormPatients : Form
    {
        DB DB = new DB();
        int selectedRow;
        public FormPatients()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Closed += (s, args) => this.Close();
            this.Hide();
            formMenu.Show();
        }

        private void CreateColumns()
        {
            dgv_patients.Columns.Add("patient_id", "id");
            dgv_patients.Columns.Add("patient_lastname", "ФИО");
            dgv_patients.Columns.Add("patient_born", "Дата рождения");
            dgv_patients.Columns.Add("patient_number", "Телефон");
      }
        private void ReadSingleRow(IDataRecord record)
        {
                dgv_patients.Rows.Add(record.GetInt32(0), 
                    record.GetString(1) + " " + record.GetString(2) + " " + record.GetString(3), 
                    record.GetDateTime(4), record.GetString(9));              
        }

        private void RefreshDgv()
        {
            dgv_patients.Rows.Clear();
            string queryString = $"SELECT * FROM table_patients";

            SqlCommand com = new SqlCommand(queryString, DB.GetConnection());

            DB.OpenConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(reader);
            }
            reader.Close();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv();
        }

        private void button_patient_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                int id = Convert.ToInt32(dgv_patients.Rows[selectedRow].Cells[0].Value);
                FormPatient formPatient = new FormPatient(id);
                formPatient.Closed += (s, args) => this.Close();
                this.Hide();
                formPatient.Show();
            }
            else
            {
                MessageBox.Show("Не выбран пациент");
            }
            
        }

        private void dgv_patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient(0);
            formPatient.Closed += (s, args) => this.Close();
            this.Hide();
            formPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu formPatient = new FormMenu();
            formPatient.Closed += (s, args) => this.Close();
            this.Hide();
            formPatient.Show();
        }

    }
}
