using ProyectoEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmpleados.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Empleados> epleados { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
