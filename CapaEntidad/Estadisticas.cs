using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Estadisticas
    {
        public string Nombre { get; set; }
        public int CantidadVendida { get; set; }
        public decimal Ingresos { get; set; }
        public Estadisticas(string nombre, int cantidadVendida, decimal ingresos)
        {
            Nombre = nombre;
            CantidadVendida = cantidadVendida;
            Ingresos = ingresos;
        }
    }
    public class VendedorEstadistica
    {
        public string Nombre { get; set; }
        public int Ventas { get; set; }
        public VendedorEstadistica(string nombre, int ventas)
        {
            Nombre = nombre;
            Ventas = ventas;
        }
    }
}
