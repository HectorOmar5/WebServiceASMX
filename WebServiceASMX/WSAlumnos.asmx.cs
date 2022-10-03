using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Negocio;

namespace WebServiceASMX
{
    /// <summary>
    /// Descripción breve de WSAlumnos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumnos : System.Web.Services.WebService
    {

        [WebMethod]
        public AportacionesIMSS CalcularIMSS(int id)
        {
            return NAlumno.CalcularIMSS(id);
        }

        [WebMethod]
        public ItemTablaISR CalcularISR(int id)
        {
            NAlumno alumno = new NAlumno();
            return alumno.CalcularISR(id);
        }
        
    }
}
