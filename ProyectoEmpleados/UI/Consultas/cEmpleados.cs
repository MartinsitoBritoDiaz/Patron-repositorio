using ProyectoEmpleados.BLL;
using ProyectoEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpleados.UI.Consultas
{
    public partial class cEmpleados : Form
    {
        public cEmpleados()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            var listado = new List<Empleados>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.EmpleadoId == id);
                        break;

                    case 2:
                        listado = repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        listado = repositorio.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                        break;

                    case 4:
                        listado = repositorio.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                        break;

                    case 5:
                        decimal sueldo = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.Sueldo == sueldo);
                        break;

                    case 6:
                        decimal incentivo = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.Sueldo == incentivo);
                        break;
                }

                listado = listado.Where(c => c.Fecha >= DesdeDateTimePicker.Value && c.Fecha <= HastaDateTimePicker.Value).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
