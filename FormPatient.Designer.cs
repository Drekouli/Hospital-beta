namespace Hospital
{
    partial class FormPatient
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_midname = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_passport = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_work = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.dtp_born = new System.Windows.Forms.DateTimePicker();
            this.pbox_photo = new System.Windows.Forms.PictureBox();
            this.groupbox_patient = new System.Windows.Forms.GroupBox();
            this.btn_patient_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupbox_card = new System.Windows.Forms.GroupBox();
            this.btn_card_save = new System.Windows.Forms.Button();
            this.checkbox_next = new System.Windows.Forms.CheckBox();
            this.groupbox_photo = new System.Windows.Forms.GroupBox();
            this.btn_photo = new System.Windows.Forms.Button();
            this.dtp_polis_end = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_polis = new System.Windows.Forms.TextBox();
            this.dtp_next = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_last = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_create = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_card_id = new System.Windows.Forms.TextBox();
            this.dgv_notes = new System.Windows.Forms.DataGridView();
            this.groupbox_notes = new System.Windows.Forms.GroupBox();
            this.dtp_note = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_doc_id = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_diagnosis = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_card_edit = new System.Windows.Forms.Button();
            this.btn_edit_note = new System.Windows.Forms.Button();
            this.btn_add_note = new System.Windows.Forms.Button();
            this.btn_save_note = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_photo)).BeginInit();
            this.groupbox_patient.SuspendLayout();
            this.groupbox_card.SuspendLayout();
            this.groupbox_photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).BeginInit();
            this.groupbox_notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_id.Location = new System.Drawing.Point(419, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(62, 27);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Номер паспорта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Адрес прописки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Работа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Номер телефона";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Почта";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(0, 0);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(15, 24);
            this.button_back.TabIndex = 12;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_lastname.Location = new System.Drawing.Point(148, 74);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(333, 27);
            this.txt_lastname.TabIndex = 13;
            this.txt_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_firstname.Location = new System.Drawing.Point(148, 107);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(333, 27);
            this.txt_firstname.TabIndex = 14;
            this.txt_firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_midname
            // 
            this.txt_midname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_midname.Location = new System.Drawing.Point(148, 140);
            this.txt_midname.Name = "txt_midname";
            this.txt_midname.Size = new System.Drawing.Size(333, 27);
            this.txt_midname.TabIndex = 15;
            this.txt_midname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_gender.Location = new System.Drawing.Point(148, 206);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(333, 27);
            this.txt_gender.TabIndex = 17;
            this.txt_gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_passport
            // 
            this.txt_passport.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_passport.Location = new System.Drawing.Point(148, 239);
            this.txt_passport.Name = "txt_passport";
            this.txt_passport.Size = new System.Drawing.Size(333, 27);
            this.txt_passport.TabIndex = 18;
            this.txt_passport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_adress.Location = new System.Drawing.Point(148, 272);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(333, 27);
            this.txt_adress.TabIndex = 19;
            this.txt_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_email.Location = new System.Drawing.Point(148, 371);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(333, 27);
            this.txt_email.TabIndex = 20;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_work
            // 
            this.txt_work.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_work.Location = new System.Drawing.Point(148, 305);
            this.txt_work.Name = "txt_work";
            this.txt_work.Size = new System.Drawing.Size(333, 27);
            this.txt_work.TabIndex = 20;
            this.txt_work.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_number.Location = new System.Drawing.Point(148, 338);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(333, 27);
            this.txt_number.TabIndex = 21;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_born
            // 
            this.dtp_born.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_born.Location = new System.Drawing.Point(148, 175);
            this.dtp_born.Name = "dtp_born";
            this.dtp_born.Size = new System.Drawing.Size(333, 20);
            this.dtp_born.TabIndex = 22;
            // 
            // pbox_photo
            // 
            this.pbox_photo.InitialImage = null;
            this.pbox_photo.Location = new System.Drawing.Point(6, 14);
            this.pbox_photo.Name = "pbox_photo";
            this.pbox_photo.Size = new System.Drawing.Size(106, 111);
            this.pbox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_photo.TabIndex = 23;
            this.pbox_photo.TabStop = false;
            // 
            // groupbox_patient
            // 
            this.groupbox_patient.Controls.Add(this.btn_patient_save);
            this.groupbox_patient.Controls.Add(this.label1);
            this.groupbox_patient.Controls.Add(this.txt_id);
            this.groupbox_patient.Controls.Add(this.dtp_born);
            this.groupbox_patient.Controls.Add(this.label2);
            this.groupbox_patient.Controls.Add(this.txt_number);
            this.groupbox_patient.Controls.Add(this.label3);
            this.groupbox_patient.Controls.Add(this.txt_work);
            this.groupbox_patient.Controls.Add(this.label4);
            this.groupbox_patient.Controls.Add(this.txt_email);
            this.groupbox_patient.Controls.Add(this.label5);
            this.groupbox_patient.Controls.Add(this.txt_adress);
            this.groupbox_patient.Controls.Add(this.label6);
            this.groupbox_patient.Controls.Add(this.txt_passport);
            this.groupbox_patient.Controls.Add(this.label7);
            this.groupbox_patient.Controls.Add(this.txt_gender);
            this.groupbox_patient.Controls.Add(this.label8);
            this.groupbox_patient.Controls.Add(this.txt_midname);
            this.groupbox_patient.Controls.Add(this.label9);
            this.groupbox_patient.Controls.Add(this.txt_firstname);
            this.groupbox_patient.Controls.Add(this.label10);
            this.groupbox_patient.Controls.Add(this.txt_lastname);
            this.groupbox_patient.Controls.Add(this.label11);
            this.groupbox_patient.Enabled = false;
            this.groupbox_patient.Location = new System.Drawing.Point(10, 38);
            this.groupbox_patient.Name = "groupbox_patient";
            this.groupbox_patient.Size = new System.Drawing.Size(492, 594);
            this.groupbox_patient.TabIndex = 24;
            this.groupbox_patient.TabStop = false;
            this.groupbox_patient.Text = "Пациент";
            // 
            // btn_patient_save
            // 
            this.btn_patient_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_patient_save.Location = new System.Drawing.Point(10, 559);
            this.btn_patient_save.Name = "btn_patient_save";
            this.btn_patient_save.Size = new System.Drawing.Size(471, 29);
            this.btn_patient_save.TabIndex = 27;
            this.btn_patient_save.Text = "Сохранить";
            this.btn_patient_save.UseVisualStyleBackColor = true;
            this.btn_patient_save.Click += new System.EventHandler(this.btn_patient_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit.Location = new System.Drawing.Point(25, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(477, 27);
            this.btn_edit.TabIndex = 25;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // groupbox_card
            // 
            this.groupbox_card.Controls.Add(this.btn_card_save);
            this.groupbox_card.Controls.Add(this.checkbox_next);
            this.groupbox_card.Controls.Add(this.groupbox_photo);
            this.groupbox_card.Controls.Add(this.dtp_polis_end);
            this.groupbox_card.Controls.Add(this.label18);
            this.groupbox_card.Controls.Add(this.txt_polis);
            this.groupbox_card.Controls.Add(this.dtp_next);
            this.groupbox_card.Controls.Add(this.label17);
            this.groupbox_card.Controls.Add(this.label16);
            this.groupbox_card.Controls.Add(this.dtp_last);
            this.groupbox_card.Controls.Add(this.label15);
            this.groupbox_card.Controls.Add(this.dtp_create);
            this.groupbox_card.Controls.Add(this.label14);
            this.groupbox_card.Controls.Add(this.label12);
            this.groupbox_card.Controls.Add(this.txt_card_id);
            this.groupbox_card.Enabled = false;
            this.groupbox_card.Location = new System.Drawing.Point(508, 38);
            this.groupbox_card.Name = "groupbox_card";
            this.groupbox_card.Size = new System.Drawing.Size(707, 200);
            this.groupbox_card.TabIndex = 26;
            this.groupbox_card.TabStop = false;
            this.groupbox_card.Text = "Карта";
            // 
            // btn_card_save
            // 
            this.btn_card_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_card_save.Location = new System.Drawing.Point(145, 147);
            this.btn_card_save.Name = "btn_card_save";
            this.btn_card_save.Size = new System.Drawing.Size(542, 29);
            this.btn_card_save.TabIndex = 39;
            this.btn_card_save.Text = "Сохранить";
            this.btn_card_save.UseVisualStyleBackColor = true;
            this.btn_card_save.Click += new System.EventHandler(this.btn_card_save_Click);
            // 
            // checkbox_next
            // 
            this.checkbox_next.AutoSize = true;
            this.checkbox_next.Location = new System.Drawing.Point(646, 124);
            this.checkbox_next.Name = "checkbox_next";
            this.checkbox_next.Size = new System.Drawing.Size(15, 14);
            this.checkbox_next.TabIndex = 36;
            this.checkbox_next.UseVisualStyleBackColor = true;
            this.checkbox_next.CheckedChanged += new System.EventHandler(this.checkbox_next_CheckedChanged);
            // 
            // groupbox_photo
            // 
            this.groupbox_photo.Controls.Add(this.pbox_photo);
            this.groupbox_photo.Controls.Add(this.btn_photo);
            this.groupbox_photo.Location = new System.Drawing.Point(6, 16);
            this.groupbox_photo.Name = "groupbox_photo";
            this.groupbox_photo.Size = new System.Drawing.Size(119, 167);
            this.groupbox_photo.TabIndex = 34;
            this.groupbox_photo.TabStop = false;
            // 
            // btn_photo
            // 
            this.btn_photo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_photo.Location = new System.Drawing.Point(6, 131);
            this.btn_photo.Name = "btn_photo";
            this.btn_photo.Size = new System.Drawing.Size(106, 29);
            this.btn_photo.TabIndex = 33;
            this.btn_photo.Text = "Изменить";
            this.btn_photo.UseVisualStyleBackColor = true;
            this.btn_photo.Click += new System.EventHandler(this.btn_photo_Click);
            // 
            // dtp_polis_end
            // 
            this.dtp_polis_end.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_polis_end.Location = new System.Drawing.Point(145, 118);
            this.dtp_polis_end.Name = "dtp_polis_end";
            this.dtp_polis_end.Size = new System.Drawing.Size(118, 20);
            this.dtp_polis_end.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(141, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 19);
            this.label18.TabIndex = 31;
            this.label18.Text = "Конец ПОЛИСа";
            // 
            // txt_polis
            // 
            this.txt_polis.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_polis.Location = new System.Drawing.Point(297, 111);
            this.txt_polis.Name = "txt_polis";
            this.txt_polis.Size = new System.Drawing.Size(142, 27);
            this.txt_polis.TabIndex = 24;
            this.txt_polis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_next
            // 
            this.dtp_next.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_next.Location = new System.Drawing.Point(474, 118);
            this.dtp_next.Name = "dtp_next";
            this.dtp_next.Size = new System.Drawing.Size(152, 20);
            this.dtp_next.TabIndex = 30;
            this.dtp_next.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(470, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Следующеее посещение";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(293, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 29;
            this.label16.Text = "ПОЛИС";
            // 
            // dtp_last
            // 
            this.dtp_last.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_last.Location = new System.Drawing.Point(297, 47);
            this.dtp_last.Name = "dtp_last";
            this.dtp_last.Size = new System.Drawing.Size(171, 20);
            this.dtp_last.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(293, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 19);
            this.label15.TabIndex = 27;
            this.label15.Text = "Последнее посещение";
            // 
            // dtp_create
            // 
            this.dtp_create.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_create.Location = new System.Drawing.Point(145, 47);
            this.dtp_create.Name = "dtp_create";
            this.dtp_create.Size = new System.Drawing.Size(142, 20);
            this.dtp_create.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(141, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "Дата регистарции";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(579, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "id";
            // 
            // txt_card_id
            // 
            this.txt_card_id.Enabled = false;
            this.txt_card_id.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_card_id.Location = new System.Drawing.Point(607, 12);
            this.txt_card_id.Name = "txt_card_id";
            this.txt_card_id.Size = new System.Drawing.Size(80, 27);
            this.txt_card_id.TabIndex = 23;
            this.txt_card_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_notes
            // 
            this.dgv_notes.AllowUserToAddRows = false;
            this.dgv_notes.AllowUserToDeleteRows = false;
            this.dgv_notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_notes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notes.Location = new System.Drawing.Point(508, 363);
            this.dgv_notes.Name = "dgv_notes";
            this.dgv_notes.ReadOnly = true;
            this.dgv_notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_notes.Size = new System.Drawing.Size(594, 269);
            this.dgv_notes.TabIndex = 35;
            this.dgv_notes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notes_CellClick);
            // 
            // groupbox_notes
            // 
            this.groupbox_notes.Controls.Add(this.dtp_note);
            this.groupbox_notes.Controls.Add(this.label13);
            this.groupbox_notes.Controls.Add(this.label19);
            this.groupbox_notes.Controls.Add(this.txt_doc_id);
            this.groupbox_notes.Controls.Add(this.label20);
            this.groupbox_notes.Controls.Add(this.txt_diagnosis);
            this.groupbox_notes.Controls.Add(this.label21);
            this.groupbox_notes.Controls.Add(this.txt_comment);
            this.groupbox_notes.Enabled = false;
            this.groupbox_notes.Location = new System.Drawing.Point(508, 244);
            this.groupbox_notes.Name = "groupbox_notes";
            this.groupbox_notes.Size = new System.Drawing.Size(707, 113);
            this.groupbox_notes.TabIndex = 37;
            this.groupbox_notes.TabStop = false;
            this.groupbox_notes.Text = "Записи";
            // 
            // dtp_note
            // 
            this.dtp_note.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_note.Location = new System.Drawing.Point(125, 87);
            this.dtp_note.Name = "dtp_note";
            this.dtp_note.Size = new System.Drawing.Size(197, 20);
            this.dtp_note.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "id доктора";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 19);
            this.label19.TabIndex = 29;
            this.label19.Text = "Диагноз";
            // 
            // txt_doc_id
            // 
            this.txt_doc_id.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_doc_id.Location = new System.Drawing.Point(125, 18);
            this.txt_doc_id.Name = "txt_doc_id";
            this.txt_doc_id.Size = new System.Drawing.Size(197, 27);
            this.txt_doc_id.TabIndex = 32;
            this.txt_doc_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(328, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 19);
            this.label20.TabIndex = 30;
            this.label20.Text = "Комментарий";
            // 
            // txt_diagnosis
            // 
            this.txt_diagnosis.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_diagnosis.Location = new System.Drawing.Point(125, 51);
            this.txt_diagnosis.Name = "txt_diagnosis";
            this.txt_diagnosis.Size = new System.Drawing.Size(197, 27);
            this.txt_diagnosis.TabIndex = 33;
            this.txt_diagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(8, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 19);
            this.label21.TabIndex = 31;
            this.label21.Text = "Дата";
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_comment.Location = new System.Drawing.Point(332, 38);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_comment.Size = new System.Drawing.Size(369, 69);
            this.txt_comment.TabIndex = 34;
            this.txt_comment.Text = "\r\n";
            // 
            // btn_card_edit
            // 
            this.btn_card_edit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_card_edit.Location = new System.Drawing.Point(508, 8);
            this.btn_card_edit.Name = "btn_card_edit";
            this.btn_card_edit.Size = new System.Drawing.Size(707, 27);
            this.btn_card_edit.TabIndex = 38;
            this.btn_card_edit.Text = "Редактировать";
            this.btn_card_edit.UseVisualStyleBackColor = true;
            this.btn_card_edit.Click += new System.EventHandler(this.btn_card_edit_Click);
            // 
            // btn_edit_note
            // 
            this.btn_edit_note.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_note.Location = new System.Drawing.Point(1115, 363);
            this.btn_edit_note.Name = "btn_edit_note";
            this.btn_edit_note.Size = new System.Drawing.Size(100, 29);
            this.btn_edit_note.TabIndex = 28;
            this.btn_edit_note.Text = "Изменить";
            this.btn_edit_note.UseVisualStyleBackColor = true;
            this.btn_edit_note.Click += new System.EventHandler(this.btn_edit_note_Click);
            // 
            // btn_add_note
            // 
            this.btn_add_note.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_note.Location = new System.Drawing.Point(1115, 398);
            this.btn_add_note.Name = "btn_add_note";
            this.btn_add_note.Size = new System.Drawing.Size(100, 29);
            this.btn_add_note.TabIndex = 39;
            this.btn_add_note.Text = "Добавить";
            this.btn_add_note.UseVisualStyleBackColor = true;
            this.btn_add_note.Click += new System.EventHandler(this.btn_add_note_Click);
            // 
            // btn_save_note
            // 
            this.btn_save_note.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save_note.Location = new System.Drawing.Point(1115, 603);
            this.btn_save_note.Name = "btn_save_note";
            this.btn_save_note.Size = new System.Drawing.Size(100, 29);
            this.btn_save_note.TabIndex = 40;
            this.btn_save_note.Text = "Сохранить";
            this.btn_save_note.UseVisualStyleBackColor = true;
            this.btn_save_note.Click += new System.EventHandler(this.btn_save_note_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 644);
            this.Controls.Add(this.btn_save_note);
            this.Controls.Add(this.btn_add_note);
            this.Controls.Add(this.btn_edit_note);
            this.Controls.Add(this.btn_card_edit);
            this.Controls.Add(this.dgv_notes);
            this.Controls.Add(this.groupbox_notes);
            this.Controls.Add(this.groupbox_card);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.groupbox_patient);
            this.Controls.Add(this.button_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациент";
            this.Load += new System.EventHandler(this.FormPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_photo)).EndInit();
            this.groupbox_patient.ResumeLayout(false);
            this.groupbox_patient.PerformLayout();
            this.groupbox_card.ResumeLayout(false);
            this.groupbox_card.PerformLayout();
            this.groupbox_photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).EndInit();
            this.groupbox_notes.ResumeLayout(false);
            this.groupbox_notes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_midname;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_passport;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_work;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.DateTimePicker dtp_born;
        private System.Windows.Forms.PictureBox pbox_photo;
        private System.Windows.Forms.GroupBox groupbox_patient;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox groupbox_card;
        private System.Windows.Forms.DateTimePicker dtp_next;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_create;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_card_id;
        private System.Windows.Forms.DateTimePicker dtp_polis_end;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_polis;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtp_last;
        private System.Windows.Forms.GroupBox groupbox_photo;
        private System.Windows.Forms.Button btn_photo;
        private System.Windows.Forms.DataGridView dgv_notes;
        private System.Windows.Forms.CheckBox checkbox_next;
        private System.Windows.Forms.Button btn_patient_save;
        private System.Windows.Forms.Button btn_card_save;
        private System.Windows.Forms.GroupBox groupbox_notes;
        private System.Windows.Forms.Button btn_card_edit;
        private System.Windows.Forms.DateTimePicker dtp_note;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_doc_id;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_diagnosis;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Button btn_edit_note;
        private System.Windows.Forms.Button btn_add_note;
        private System.Windows.Forms.Button btn_save_note;
    }
}