using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        // Cadena de conexión a la base de datos, obtenida del archivo de configuración
        public static string cadena = ConfigurationManager.ConnectionStrings["conexion_grupo13"].ToString();
    }
}
