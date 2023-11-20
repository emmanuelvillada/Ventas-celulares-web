using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiciosCelulares.Models;
using ServiciosCelulares.Clases;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiciosCelulares.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class EmpleadoController : ApiController
    {
        public List<Empleado> Get()
        {
            clsEmpleado empleado = new clsEmpleado();
            return empleado.ListarEmpleados();
        }
    }
}