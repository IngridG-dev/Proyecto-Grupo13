using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Categotia
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = @"SELECT id_categoria, descripcion, estado FROM CATEGORIA
                                WHERE estado = 1
                                ORDER BY descripcion";
                using (SqlCommand cmd = new SqlCommand(query, oconexion))
                {
                    cmd.CommandType = CommandType.Text; //especifica que el comando es de tipo texto
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    { 
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                descripcion = dr["descripcion"].ToString(),
                                estado = Convert.ToInt32(dr["estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
