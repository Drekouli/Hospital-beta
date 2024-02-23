namespace Hospital
{
    partial class FormPatients
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
            this.button_patient = new System.Windows.Forms.Button();
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // button_patient
            // 
            this.button_patient.Location = new System.Drawing.Point(515, 28);
            this.button_patient.Name = "button_patient";
            this.button_patient.Size = new System.Drawing.Size(92, 25);
            this.button_patient.TabIndex = 2;
            this.button_patient.Text = "Подробнее";
            this.button_patient.UseVisualStyleBackColor = true;
            this.button_patient.Click += new System.EventHandler(this.button_patient_Click);
            // 
            // dgv_patients
            // 
            this.dgv_patients.AllowUserToAddRows = false;
            this.dgv_patients.AllowUserToDeleteRows = false;
            this.dgv_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(22, 28);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.ReadOnly = true;
            this.dgv_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patients.Size = new System.Drawing.Size(463, 431);
            this.dgv_patients.TabIndex = 3;
            this.dgv_patients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patients_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(515, 80);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 25);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_patients);
            this.Controls.Add(this.button_patient);
            this.Name = "FormPatients";
            this.Text = "FormPatients";
            this.Load += new System.EventHandler(this.FormPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_patient;
        private System.Windows.Forms.DataGridView dgv_patients;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}