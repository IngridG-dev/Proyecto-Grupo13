using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CapaLogica
{
    public class CL_Estadistica
    {
        private CD_Estadistica objCapaDatos = new CD_Estadistica();

        public List<Estadisticas> productosMasVendidos(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.productosMasVendidos(desde, hasta);
        }

        public List<Estadisticas> categoriasMasVendidas(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.categoriasMasVendidas(desde, hasta);
        }

        public List<VendedorEstadistica> ventasPorVendedor(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.ventasPorVendedor(desde, hasta);
        }
        public List<Periodo> ventasPorPeriodo(DateTime? desde, DateTime? hasta, string grupoPeriodo)
        {
            // obtenemos todas las ventas
            List<Venta> ventas = new CL_Venta().ListarTodasLasVentas(null, null);

            List<Periodo> resultado = new List<Periodo>();

            // aplicamos el rango seleccionado
            if (desde.HasValue)
                ventas = ventas.Where(v => v.fechaCreacion >= desde.Value.Date).ToList();

            if (hasta.HasValue)
                ventas = ventas.Where(v => v.fechaCreacion < hasta.Value.Date.AddDays(1)).ToList();

            if (ventas.Count == 0)
                return resultado;

            DateTime inicio = (desde ?? ventas.Min(v => v.fechaCreacion)).Date;
            DateTime fin = (hasta ?? ventas.Max(v => v.fechaCreacion)).Date;

            if (fin < inicio)
                return resultado;

            DateTime actual = inicioDelPeriodo(inicio, grupoPeriodo);

            while (actual <= fin)
            {
                DateTime siguiente = siguientePeriodo(actual, grupoPeriodo);

                List<Venta> delPeriodo = ventas
                    .Where(v => v.fechaCreacion >= actual && v.fechaCreacion < siguiente).ToList();

                resultado.Add(new Periodo(
                    etiquetaPeriodo(actual, grupoPeriodo), actual, delPeriodo.Count, delPeriodo.Sum(v => v.montoPago)
                ));
                actual = siguiente;
            }

            return resultado;
        }
        private DateTime inicioDelPeriodo(DateTime fecha, string grupoPeriodo)
        {
            switch (grupoPeriodo)
            {
                case "Semana": return fecha.AddDays(-(((int)fecha.DayOfWeek + 6) % 7));   // la semana empieza el lunes
                case "Mes": return new DateTime(fecha.Year, fecha.Month, 1);
                case "Año": return new DateTime(fecha.Year, 1, 1);
                default: return fecha.Date;   // Día
            }
        }

        private DateTime siguientePeriodo(DateTime inicio, string grupoPeriodo)
        {
            switch (grupoPeriodo)
            {
                case "Semana": return inicio.AddDays(7);
                case "Mes": return inicio.AddMonths(1);
                case "Año": return inicio.AddYears(1);
                default: return inicio.AddDays(1);
            }
        }

        private string etiquetaPeriodo(DateTime inicio, string grupoPeriodo)
        {
            CultureInfo es = new CultureInfo("es-AR");

            switch (grupoPeriodo)
            {
                case "Semana":
                    return "Sem " + inicio.ToString("dd/MM", es);
                case "Mes":
                    string mes = inicio.ToString("MMM yyyy", es);
                    return char.ToUpper(mes[0]) + mes.Substring(1);
                case "Año":
                    return inicio.Year.ToString();
                default:
                    return inicio.ToString("dd/MM", es);
            }
        }
        public List<Estadisticas> ventasPorMetodoPago(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.ventasPorMetodoPago(desde, hasta);
        }
    }
}
