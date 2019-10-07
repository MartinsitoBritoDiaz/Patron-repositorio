using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoEmpleados.BLL;
using ProyectoEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmpleados.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();

            Empleados empleado = repositorio.Buscar(2);

            bool paso = false;

            if (empleado != null)
                paso = true;
            
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();

            Assert.IsTrue(repositorio.Eliminar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();

            Empleados empleados = new Empleados();
            empleados.EmpleadoId = 0;
            empleados.Fecha = DateTime.Now;
            empleados.Nombres = "Martinsito";
            empleados.Direccion = "Nagua";
            empleados.Cedula = "40233030523";
            empleados.Celular = "8092128159";
            empleados.Telefono = "8095847013";
            empleados.Sueldo = 85000;
            empleados.Incentivo = 35000;

            Assert.IsTrue(repositorio.Guardar(empleados));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();

            Empleados empleados = new Empleados();
            empleados.EmpleadoId = 2;
            empleados.Fecha = DateTime.Now;
            empleados.Nombres = "Martinsito";
            empleados.Direccion = "Nagua";
            empleados.Cedula = "40233030523";
            empleados.Celular = "8092128159";
            empleados.Telefono = "8095847013";
            empleados.Sueldo = 85000;
            empleados.Incentivo = 35000;

            Assert.IsTrue(repositorio.Modificar(empleados));
        }
    }
}