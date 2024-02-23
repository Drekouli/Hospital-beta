using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_patients_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.Closed += (s, args) => this.Close();
            this.Hide();
            formPatients.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.Closed += (s, args) => this.Close();
            this.Hide();
            formDoctors.Show();
        }
    }
}
