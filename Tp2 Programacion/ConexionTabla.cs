using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    internal class ConexionTabla
    {

        public List<Tabla> listar()
        {
            List<Tabla> lista = new List<Tabla>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id,Nombre from ARTICULOS ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Tabla aux = new Tabla();
                    aux.Id_Articulo = (int)lector["Id"];
                    aux.Nombre_Articulo = (string)lector["Nombre"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
 }

