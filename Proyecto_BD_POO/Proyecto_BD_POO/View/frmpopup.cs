using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_BD_POO.SqlServerContext;

namespace Proyecto_BD_POO.View
{
    public partial class frmpopup : Form
    {
        public frmpopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new PROYECTO_BD_POOContext();

            Employee employee = 
            Cabin cabin = Cabin comboBox1.Items;

                Employee edb = db.Set<Employee>().SingleOrDefault(e => e.Id == employee.Id);

            Cabin cdb = db.Set<Cabin>().SingleOrDefault(c => c.CabinNumber == cabin.CabinNumber);

            List<Registry> registerylist = db.Registries
                .Include(r => r.CabinNumber)
                .Include(r => r.IdEmployee)
                .OrderBy(r => r.IdEmployee)
                .ToList();

            Registry r = new Registry(cdb, edb, DateTime.Today);
            db.Add(r);
            db.SaveChanges();
        }
    }
}