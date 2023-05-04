using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tp2_Programacion
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT a.id,a.Codigo,a.Descripcion,a.Nombre,c.Descripcion as 'Categoria', m.Descripcion as 'Marca', a.Precio from ARTICULOS a inner join categorias c on c.Id = a.IdCategoria INNER join MARCAS m on m.Id = a.IdMarca ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux._codArticulo = (string)datos.Lector["Codigo"];
                    aux._nombre = (string)datos.Lector["Nombre"];
                    aux._descripcion = (string)datos.Lector["Descripcion"];
                    aux._marca = new Marca();
                    aux._marca._nombre = (string)datos.Lector["Marca"];
                    aux._categoria = new Categoria();
                    aux._categoria._descripcion = (string)datos.Lector["Categoria"];
                    aux._precio = (float)datos.Lector.GetDecimal(6);

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Marca> listarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Descripcion, Id from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux._nombre = (string)datos.Lector["Descripcion"];
                    aux._idMarca = (int)datos.Lector["Id"];
            
                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Descripcion, Id from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux._descripcion = (string)datos.Lector["Descripcion"];
                    aux._idCategoria = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }



        public void Agregar(Articulo nuevo)
        {
			AccesoDatos datos = new AccesoDatos();
            
			try
			{
				datos.setearConsulta("INSERT into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)values('"+ nuevo._codArticulo +"', '"+ nuevo._nombre +"','"+ nuevo._descripcion + "', @idMarca, @idCategoria, "+ nuevo._precio+")");
                datos.setearParametro("@idMarca", nuevo._marca._idMarca);
                datos.setearParametro("@idCategoria", nuevo._categoria._idCategoria);

                datos.ejecutarAccion();

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
