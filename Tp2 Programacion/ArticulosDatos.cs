using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tp2_Programacion
{
    class ArticulosDatos
    {
        public List<Artículo> listar()
        {
            List<Artículo> lista = new List<Artículo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType=System.Data.CommandType.Text;
                comando.CommandText = "select codigo,Nombre,precio from ARTICULOS ";
                comando.Connection = conexion;

                conexion.Open();
                lector=comando.ExecuteReader();

                while(lector.Read()) {
                    Artículo aux = new Artículo();
                    aux._codArticulo = (string)lector["codigo"];
                    aux._nombre = (string)lector["Nombre"];
                    /*aux._marca = (Marca)lector["IdMarca"];
                    aux._categoria = (Categoria)lector["IdCategoria"];*/
                    //aux._precio = lector.GetInt32(2);

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
