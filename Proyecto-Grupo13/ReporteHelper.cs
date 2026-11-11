using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13
{
    public class ReporteHelper
    {
        public static string ObtenerTextoPeriodo(
           DateTime? desde, DateTime? hasta,
           DataGridView grilla, int columnaFecha,
           string nombre = "las compras",
           string formatoFecha = "dd/MM/yyyy")
        {
            if (desde.HasValue && hasta.HasValue)
                return $"{desde.Value:dd/MM/yyyy} al {hasta.Value:dd/MM/yyyy}";
            if (desde.HasValue)
                return $"Desde el {desde.Value:dd/MM/yyyy}";
            if (hasta.HasValue)
                return $"Hasta el {hasta.Value:dd/MM/yyyy}";

            // Sin filtro: primera y última fecha de las filas visibles
            List<DateTime> fechas = new List<DateTime>();
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                if (fila.IsNewRow || !fila.Visible) continue;

                if (DateTime.TryParseExact(
                        fila.Cells[columnaFecha].Value?.ToString(),
                        formatoFecha,
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out DateTime f))
                {
                    fechas.Add(f);
                }
            }

            if (fechas.Count == 0)
                return $"Todas {nombre}";

            return $"Todas {nombre} ({fechas.Min():dd/MM/yyyy} al {fechas.Max():dd/MM/yyyy})";
        }
    }
}
