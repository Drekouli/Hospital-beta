using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Imaging;


namespace Hospital
{
    public partial class FormPatient : Form
    {
        DB DB = new DB();
        int selectedRow;
        int patient_id = 0;
        bool update;
        public FormPatient(int id)
        {
            InitializeComponent();
            patient_id = id;
        }

        private void PatientInfo()
        {
                string queryString = $"SELECT * FROM table_patients WHERE patient_id = {patient_id}";

                SqlCommand com = new SqlCommand(queryString, DB.GetConnection());

                DB.OpenConnection();
                txt_id.Text = patient_id.ToString();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    txt_lastname.Text = reader.GetString(1);
                    txt_firstname.Text = reader.GetString(2);
                    txt_midname.Text = reader.GetString(3);
                    dtp_born.Value = reader.GetDateTime(4);
                    txt_gender.Text = reader.GetString(5);
                    txt_passport.Text = reader.GetString(6);
                    txt_adress.Text = reader.GetString(7);
                    txt_work.Text = reader.GetString(8);
                    txt_number.Text = reader.GetString(9);
                    txt_email.Text = reader.GetString(10);
                    
                }
                reader.Close();           
        }

    
        private void CardInfo()
        {
            string queryString = $"SELECT * FROM table_cards WHERE card_patient_id = {patient_id}";

            SqlCommand com = new SqlCommand(queryString, DB.GetConnection());

            DB.OpenConnection();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                txt_card_id.Text = reader.GetInt32(0).ToString();
                dtp_create.Value = reader.GetDateTime(2);
                dtp_last.Value = reader.GetDateTime(3);
                if (reader.IsDBNull(4) == false)
                {
                    dtp_next.Value = reader.GetDateTime(4);
                    checkbox_next.Checked = true;
                }
                txt_polis.Text = reader.GetString(5);
                dtp_polis_end.Value = reader.GetDateTime(6);
                if (reader.IsDBNull(7) == false)
                {
                    var imageData = (byte[])reader.GetValue(7);
                    using (var memoryStream = new MemoryStream(imageData))
                    {
                        pbox_photo.Image = Image.FromStream(memoryStream);
                    }
                }            
            }
            reader.Close();
        }

        private void CreateColumns()
        {
            dgv_notes.Columns.Add("note_id", "id");
            dgv_notes.Columns.Add("note_card_id", "id карты");
            dgv_notes.Columns.Add("note_author", "id доктора");
            dgv_notes.Columns.Add("note_diagnosis", "Диагноз");
            dgv_notes.Columns.Add("note_comment", "Комментарий");
            dgv_notes.Columns.Add("note_date", "Дата");
            
            dgv_notes.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReadSingleRow(IDataRecord record)
        {
            try
            {
                dgv_notes.Rows.Add(record.GetInt32(0), record.GetInt32(1),
                    record.GetInt32(2), record.GetString(3),
                    record.GetString(4), record.GetDateTime(5));
            }
            catch (Exception) 
            {
                dgv_notes.Rows.Add(record.GetInt32(0), record.GetInt32(1),
                    record.GetInt32(2), record.GetString(3), 
                    "", record.GetDateTime(5));
            }
        }

        private void RefreshDgv()
        {
                dgv_notes.Rows.Clear();
                string queryString = $"SELECT * FROM table_notes WHERE note_card_id = '{txt_card_id.Text}'";

                SqlCommand com = new SqlCommand(queryString, DB.GetConnection());

                DB.OpenConnection();

                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(reader);
                }
                reader.Close();  
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            if (patient_id != 0)
            {
                PatientInfo();
                CardInfo();
                CreateColumns();
                RefreshDgv();
            }
            else
            {
                groupbox_patient.Enabled = true;
                btn_edit.Enabled = false;
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            groupbox_patient.Enabled = true;
            btn_edit.Enabled = false;
        }

        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            groupbox_patient.Enabled = false;
            btn_edit.Enabled = true;
            string query = "";
            if (patient_id != 0)
            {
                    query = $"UPDATE table_patients SET patient_lastname = '{txt_lastname.Text}', patient_firstname = '{txt_firstname.Text}', " +
                    $"patient_midname = '{txt_midname.Text}', patient_born = '{dtp_born.Value.ToString("yyyy-MM-dd")}', patient_gender = '{txt_gender.Text}', patient_passport = '{txt_passport.Text}', " +
                    $"patient_adress = '{txt_adress.Text}', patient_work = '{txt_work.Text}', patient_number = '{txt_number.Text}', " +
                    $"patient_email = '{txt_email.Text}' WHERE patient_id = {patient_id}";
            }
            else
            {
                    query = $"INSERT INTO table_patients(patient_lastname, patient_firstname, patient_midname, patient_born, patient_gender, patient_passport, patient_adress, patient_work, patient_number, patient_email)" +
                        $"VALUES ('{txt_lastname.Text}', '{txt_firstname.Text}', '{txt_midname.Text}', '{dtp_born.Value.ToString("yyyy-MM-dd")}', '{txt_gender.Text}', '{txt_passport.Text}', " +
                        $"'{txt_adress.Text}', '{txt_work.Text}', '{txt_number.Text}', '{txt_email.Text}')";  
            }

            var command = new SqlCommand(query, DB.GetConnection());
            DB.OpenConnection();

            command.ExecuteNonQuery();
           
            DB.CloseConnection();
            PatientInfo();

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.Closed += (s, args) => this.Close();
            this.Hide();
            formPatients.Show();
        }

        private void dgv_notes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dgv_notes.Rows[selectedRow];
                
                txt_doc_id.Text = row.Cells[2].Value.ToString();
                txt_diagnosis.Text = row.Cells[3].Value.ToString();
                txt_comment.Text = row.Cells[4].Value.ToString();
                dtp_note.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbox_photo.Image = Image.FromFile(openFileDialog.FileName);
                    byte[] image_bytes = File.ReadAllBytes(openFileDialog.FileName);
                    string query = $"UPDATE table_cards SET card_patient_photo = @ImageData WHERE card_id = '{txt_card_id.Text}'";
                    var command = new SqlCommand(query, DB.GetConnection());
                    command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);
                    command.Parameters["@ImageData"].Value = image_bytes;
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.CloseConnection();
                }
            }
        }
            public void Upload(PictureBox pictureBox)
            {
                //using (var command = new SqlCommand(query, DB.GetConnection()))
            }
        

        private void checkbox_next_CheckedChanged(object sender, EventArgs e)
        {
            dtp_next.Visible = checkbox_next.Checked;
        }

        private void btn_card_edit_Click(object sender, EventArgs e)
        {
            groupbox_card.Enabled = true;
            btn_card_edit.Enabled = false;
        }

        private void btn_card_save_Click(object sender, EventArgs e)
        {
            groupbox_card.Enabled = false;
            btn_card_edit.Enabled = true;
            string query = "";
            if (txt_card_id.Text != "")
            {
                if (checkbox_next.Checked)
                {
                    query = $"UPDATE table_cards SET card_create_date = '{dtp_create.Value.ToString("yyyy-MM-dd")}', " +
                    $"card_last_date = '{dtp_last.Value.ToString("yyyy-MM-dd")}', card_next_date = '{dtp_next.Value.ToString("yyyy-MM-dd")}', " +
                    $"card_polis = '{txt_polis.Text}', card_polis_end = '{dtp_polis_end.Value.ToString("yyyy-MM-dd")}' WHERE card_id = {txt_card_id.Text}";
                }
                else
                {
                    query = $"UPDATE table_cards SET card_create_date = '{dtp_create.Value.ToString("yyyy-MM-dd")}', " +
                    $"card_last_date = '{dtp_last.Value.ToString("yyyy-MM-dd")}', card_polis = '{txt_polis.Text}', " +
                    $"card_polis_end = '{dtp_polis_end.Value.ToString("yyyy-MM-dd")}' WHERE card_id = {txt_card_id.Text}";
                }
                
            }
            else
            {
                if (checkbox_next.Checked)
                {
                    query = $"INSERT INTO table_cards(card_patient_id, card_create_date, card_last_date, card_next_date, card_polis, card_polis_end)" +
                    $"VALUES ('{dtp_create.Value.ToString("yyyy-MM-dd")}', '{dtp_last.Value.ToString("yyyy-MM-dd")}', " +
                    $"'{dtp_next.Value.ToString("yyyy-MM-dd")}', '{txt_polis.Text}', '{dtp_polis_end.Value.ToString("yyyy-MM-dd")}')";
                }
                else
                {
                    query = $"INSERT INTO table_cards(card_patient_id, card_create_date, card_last_date, card_polis, card_polis_end)" +
                    $"VALUES ('{txt_id.Text}', '{dtp_create.Value.ToString("yyyy-MM-dd")}', '{dtp_last.Value.ToString("yyyy-MM-dd")}', " +
                    $"'{txt_polis.Text}', '{dtp_polis_end.Value.ToString("yyyy-MM-dd")}')";
                }
                
            }

            var command = new SqlCommand(query, DB.GetConnection());
            DB.OpenConnection();

            command.ExecuteNonQuery();

            DB.CloseConnection();
            CardInfo();
        }

        

        private void btn_edit_note_Click(object sender, EventArgs e)
        {
            groupbox_notes.Enabled = true;
            dgv_notes.Enabled = false;
            update = true;
        }

        private void btn_add_note_Click(object sender, EventArgs e)
        {
            txt_doc_id.Text = "";
            txt_diagnosis.Text = "";
            txt_comment.Text = "";
            dtp_note.Text = "";
            groupbox_notes.Enabled = true;
            dgv_notes.Enabled = false;
            update = false;
        }

        private void Save()
        {
            string query = "";
            if (update)
            {
                query = $"UPDATE table_notes SET note_author = {txt_doc_id.Text}, " +
                    $"note_diagnosis = '{txt_diagnosis.Text}', note_comment = '{txt_comment.Text}', " +
                    $"note_date = '{dtp_note.Value.ToString("yyyy-MM-dd")}' WHERE note_id = {dgv_notes.Rows[selectedRow].Cells[0].Value.ToString()}";
            }
            else
            {
                query = $"INSERT INTO table_notes(note_card_id, note_author, note_diagnosis, note_comment, note_date)" +
                    $"VALUES({txt_card_id.Text}, {txt_doc_id.Text}, '{txt_diagnosis.Text}', '{txt_comment.Text}', '{dtp_note.Value.ToString("yyyy-MM-dd")}')";
            }

            var command = new SqlCommand(query, DB.GetConnection());
            DB.OpenConnection();

            command.ExecuteNonQuery();

            DB.CloseConnection();
        }

        private void btn_save_note_Click(object sender, EventArgs e)
        {
            groupbox_notes.Enabled = false;
            Save();
            
            RefreshDgv();
        }
    }
}
