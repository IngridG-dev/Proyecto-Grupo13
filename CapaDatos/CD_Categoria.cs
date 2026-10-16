using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Categoria
    {
        // LISTAR CATEGORÍAS ACTIVAS
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = @"
                    SELECT id_categoria, descripcion, estado 
                    FROM Categoria 
                    WHERE estado = 1";

                using (SqlCommand comando = new SqlCommand(query, oconexion))
                {
                    oconexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                descripcion = reader["descripcion"].ToString(),
                                estado = Convert.ToInt32(reader["estado"])
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
