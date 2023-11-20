using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;

namespace ServiciosCelulares.Clases
{
    public class clsEmpleado
    {
        public Empleado empleado { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public List<Empleado> ListarEmpleados()
        {
            return DBCelulares.Empleados
                .OrderBy(p => p.Nombre)
                .ToList();

        }
    }
}