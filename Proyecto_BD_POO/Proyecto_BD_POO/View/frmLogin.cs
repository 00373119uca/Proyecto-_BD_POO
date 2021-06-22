using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_BD_POO.SqlServerContext;

namespace Proyecto_BD_POO.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            var db = new PROYECTO_BD_POOContext();

            List<Employee> listemployee = db.Employees
                .OrderBy(e => e.Id)
                .ToList();

            string username = txtuser.Text;
            string password = txtpassword.Text;

            List<Employee> result = listemployee
                .Where(e => e.Username == username && e.PasswordUser == password).ToList();

            if (result.Count > 0)
            {
                MessageBox.Show("Bienvenido!", "Terminal de la red", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                frmpopup window2 = new frmpopup();
                window2.ShowDialog();

                frmAppointmentProcess window = new frmAppointmentProcess();
                window.ShowDialog();
            }
            else
                MessageBox.Show("Usuario inexistente", "Terminal de la red", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}