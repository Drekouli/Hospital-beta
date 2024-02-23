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
    public partial class FormDoctors : Form
    {
        DB DB = new DB();
        int selectedRow;
        bool update;
        public FormDoctors()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgv_doctors.Columns.Add("doctor_id", "id");
            dgv_doctors.Columns.Add("doctor_lastname", "Фамилия");
            dgv_doctors.Columns.Add("doctor_furstname", "Имя");
            dgv_doctors.Columns.Add("doctor_midname", "Отчество");
            dgv_doctors.Columns.Add("doctor_post", "Должность");
            dgv_doctors.Columns.Add("doctor_specialization", "Специализация");
            dgv_doctors.Columns.Add("doctor_adress", "Адрес");
            dgv_doctors.Columns.Add("doctor_number", "Телефон");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7));
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_doctors";

            SqlCommand sqlCommand = new SqlCommand(queryString, DB.GetConnection());

            DB.OpenConnection();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void dgv_equipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_doctors.Rows[selectedRow];

                textBox_fio.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                textBox_post.Text = row.Cells[4].Value.ToString();
                textBox_spec.Text = row.Cells[5].Value.ToString();
                textBox_adress.Text = row.Cells[6].Value.ToString();
                textBox_number.Text = row.Cells[7].Value.ToString();

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_fio.Text = "";
            textBox_post.Text = "";
            textBox_spec.Text = "";
            textBox_adress.Text = "";
            textBox_number.Text = "";
            groupBox_data.Enabled = true;
        }

        private void Update()
        {
            groupBox_data.Enabled = false;
            string[] fio = textBox_fio.Text.Split(' ');
            string addQuery = $"UPDATE table_doctors SET doctor_lastname = '{fio[0]}', " +
                $"doctor_firstname = '{fio[1]}', doctor_midname = '{fio[2]}', " +
                $"doctor_post = '{textBox_post.Text}', doctor_specialization = '{textBox_spec.Text}', doctor_adress = '{textBox_adress.Text}', " +
                $"doctor_number = '{textBox_number.Text}' WHERE doctor_id = '{dgv_doctors.Rows[selectedRow].Cells[0].Value.ToString()}'";

            var command = new SqlCommand(addQuery, DB.GetConnection());
            DB.OpenConnection();
            command.ExecuteNonQuery();
            DB.CloseConnection();
        }

        private void Add()
        {
            groupBox_data.Enabled = false;
            string[] fio = textBox_fio.Text.Split(' ');
            string addQuery = $"INSERT INTO table_doctors(doctor_lastname, doctor_firstname, doctor_midname, doctor_post, doctor_specialization, doctor_adress, doctor_number) " +
                $"VALUES('{fio[0]}', '{fio[1]}', '{fio[2]}', '{textBox_post.Text}', '{textBox_spec.Text}', '{textBox_adress.Text}', '{textBox_number.Text}')";

            var command = new SqlCommand(addQuery, DB.GetConnection());
            DB.OpenConnection();
                command.ExecuteNonQuery();
            DB.CloseConnection();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (update)
            {
                Update();
            }
            else
            {
                Add();
            }
            RefreshDgv(dgv_doctors);
            update = false;
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM table_doctors where concat(doctor_lastname, doctor_firstname, doctor_midname, doctor_post, doctor_specialization, doctor_number) like '%{textBox_search.Text}%'";

            SqlCommand com = new SqlCommand(searchString, DB.GetConnection());

            DB.OpenConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

        }
        private void button_search_Click(object sender, EventArgs e)
        {
            Search(dgv_doctors);
        }

        private void Delete()
        {
            DB.OpenConnection();
            string id = dgv_doctors.Rows[selectedRow].Cells[0].Value.ToString();

            var deleteQuery = $"DELETE FROM table_doctors where doctor_id = '{id}'";

            var command = new SqlCommand(deleteQuery, DB.GetConnection());
            command.ExecuteNonQuery();
            DB.CloseConnection();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete();
            RefreshDgv(dgv_doctors);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            update = true;
        }

        private void textBox_staff_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormDoctors_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_doctors);
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            FormMenu formPatients = new FormMenu();
            formPatients.Closed += (s, args) => this.Close();
            this.Hide();
            formPatients.Show();
        }
    }
}
