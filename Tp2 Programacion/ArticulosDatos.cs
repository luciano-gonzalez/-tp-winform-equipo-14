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
                comando.CommandText = "SELECT a.id,a.Codigo,a.Descripcion,a.Nombre,c.Descripcion as 'Categoria', m.Descripcion as 'Marca', a.Precio from ARTICULOS a inner join categorias c on c.Id = a.IdCategoria INNER join MARCAS m on m.Id = a.IdMarca ";
                comando.Connection = conexion;

                conexion.Open();
                lector=comando.ExecuteReader();

                while(lector.Read()) {
                    Artículo aux = new Artículo();
                    aux._marca = new Marca();
                    aux._categoria = new Categoria();
                    aux._codArticulo = (string)lector["a.Codigo"];
                    aux._nombre = (string)lector["a.Nombre"];
                    aux._marca._nombre= (string)lector["m.Descripcion"];
                    aux._categoria._descripcion = (string)lector["c.Descripcion"];
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
