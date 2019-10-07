using ProyectoEmpleados.UI.Consultas;
using ProyectoEmpleados.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpleados
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEmpleados empleados = new rEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
        }

        private void EmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEmpleados empleados = new cEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
        }
    }
}
