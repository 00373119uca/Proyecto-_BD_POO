using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_BD_POO.SqlServerContext;

namespace Proyecto_BD_POO.View
{
    public partial class frmAppointmentProcess : Form
    {
        public frmAppointmentProcess()
        {
            InitializeComponent();
        }

        private void frmAppointmentProcess_Load(object sender, EventArgs e)
        {
            var db = new PROYECTO_BD_POOContext();
            List<Position> lisposition = db.Positions
                .OrderBy(p=> p.Id)
                .ToList();
            
            comboBox1.DisplayMember = "Position1";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = lisposition;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var db1 = new PROYECTO_BD_POOContext();
            List<Citizen> listcitizen = db1.Citizens
                .OrderBy(c => c.Dui)
                .ToList();

            int dui = int.Parse(txtdui.Text);
            string name = txtnombre.Text;
            string address = textBox1.Text;
            int phone = int.Parse(txttelefono.Text);
            string email = textBox2.Text;
            string disease = textBox3.Text;
            string institution = comboBox1.Text;
            
             MessageBox.Show("Se han guardado los datos del ciudadano", "formulario de citas", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}