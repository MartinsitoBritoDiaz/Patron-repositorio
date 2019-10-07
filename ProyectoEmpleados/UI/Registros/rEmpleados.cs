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

namespace ProyectoEmpleados.UI.Registros
{
    public partial class rEmpleados : Form
    {
        public rEmpleados()
        {
            InitializeComponent();
        }

        private void REmpleados_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            EmpleadoIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            NombreTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            SueldoTextBox.Text = string.Empty;
            IncentivosTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Empleados empleados)
        {
            EmpleadoIdNumericUpDown.Value = empleados.EmpleadoId;
            FechaDateTimePicker.Value = empleados.Fecha;
            NombreTextBox.Text = empleados.Nombres;
            DireccionTextBox.Text = empleados.Direccion;
            CedulaMaskedTextBox.Text = empleados.Cedula;
            CelularMaskedTextBox.Text = empleados.Celular;
            TelefonoMaskedTextBox.Text = empleados.Telefono;
            SueldoTextBox.Text = Convert.ToString(empleados.Sueldo);
            IncentivosTextBox.Text = Convert.ToString(empleados.Incentivo);
        }

        private Empleados LlenaClase()
        {
            Empleados empleados = new Empleados();

            empleados.EmpleadoId = Convert.ToInt32(EmpleadoIdNumericUpDown.Value);
            empleados.Fecha = FechaDateTimePicker.Value;
            empleados.Nombres = NombreTextBox.Text;
            empleados.Direccion = DireccionTextBox.Text;
            empleados.Cedula = CedulaMaskedTextBox.Text;
            empleados.Telefono = TelefonoMaskedTextBox.Text;
            empleados.Celular = CelularMaskedTextBox.Text;
            empleados.Sueldo = Convert.ToDecimal(SueldoTextBox.Text);
            empleados.Incentivo = Convert.ToDecimal(IncentivosTextBox.Text);

            return empleados;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            Empleados empleados = repositorio.Buscar((int)EmpleadoIdNumericUpDown.Value);

            return (empleados != null);
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo direccion no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El campo telefono no puede estar vacio");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SueldoTextBox.Text))
            {
                MyErrorProvider.SetError(SueldoTextBox, "El campo sueldo no puede estar vacio");
                SueldoTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(IncentivosTextBox.Text))
            {
                MyErrorProvider.SetError(IncentivosTextBox, "El campo incentivos no puede estar vacio");
                IncentivosTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            MyErrorProvider.Clear();
            bool paso = false;
            Empleados empleado;

            if (!Validar())
                return;

            empleado = LlenaClase();

            if (EmpleadoIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(empleado);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(empleado);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(EmpleadoIdNumericUpDown.Value), out id);

            Limpiar();

            if(repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede eliminar un empleado que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();

            int id;
            int.TryParse(Convert.ToString(EmpleadoIdNumericUpDown.Value), out id);
            Empleados empleado = new Empleados();

            Limpiar();

            empleado = repositorio.Buscar(id);

            if(empleado != null)
            {
                LlenaCampo(empleado);
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }
    }
}
