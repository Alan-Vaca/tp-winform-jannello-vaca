using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
            AccesoDatos AccesoDatos = new AccesoDatos("(local)\\SQLEXPRESS", "CATALOGO_DB");
        public List<Articulo> listar(string where)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {

                string consulta = "Select  * from ARTICULOS" + where;

                AccesoDatos.setearConsulta(consulta);

                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Marca = new Marca((int)AccesoDatos.Lector["IdMarca"], obtenerDescripcionM((int)AccesoDatos.Lector["IdMarca"]));
                    articulo.Categoria = new Categoria((int)AccesoDatos.Lector["IdCategoria"], obtenerDescripcionC((int)AccesoDatos.Lector["IdCategoria"]));
                    articulo.ID = (int)AccesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    articulo.URLimagen = (string)AccesoDatos.Lector["ImagenUrl"];
                    articulo.precio = (decimal)AccesoDatos.Lector["Precio"];
                    lista.Add(articulo);
                }
                return lista;
            }
            catch (Exception ex) { throw ex; }
            finally { AccesoDatos.cerrarConexion(); }
        }

        public string obtenerDescripcionM(int _id)
        {
            try
            {
                string consulta = "Select * from MARCAS where ID =" + _id;
                string auxDescripcion = "";
                AccesoDatos.setearConsulta(consulta);

                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    auxDescripcion = (string)AccesoDatos.Lector["Descripcion"];
                }
                return auxDescripcion;
            }
            catch (Exception ex) { throw ex; }
            finally { AccesoDatos.cerrarConexion(); }
        }

        public string obtenerDescripcionC(int _id)
        {
            try
            {
                string consulta = "Select * from CATEGORIAS where ID =" + _id;
                string auxDescripcion = "";
                AccesoDatos.setearConsulta(consulta);

                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    auxDescripcion = (string)AccesoDatos.Lector["Descripcion"];
                }
                return auxDescripcion;
            }
            catch (Exception ex) { throw ex; }
            finally { AccesoDatos.cerrarConexion(); }
        }
    }
}
