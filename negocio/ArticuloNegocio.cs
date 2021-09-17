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
                AccesoDatos.cerrarConexion();
                string consulta = "Select  * from ARTICULOS" + where;

                AccesoDatos.setearConsulta(consulta);
                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.ID = (int)AccesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    articulo.URLimagen = (string)AccesoDatos.Lector["ImagenUrl"];
                    articulo.precio = (decimal)AccesoDatos.Lector["Precio"];

                    articulo.Marca = new Marca((int)AccesoDatos.Lector["IdMarca"]);
                    articulo.Categoria = new Categoria((int)AccesoDatos.Lector["IdCategoria"]);

                    lista.Add(articulo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
            if (lista.Count != 0)
            {
                foreach (Articulo item in lista)
                {
                    item.Marca.Descripcion = obtenerDescripcionM(item.Marca.Id);
                    item.Categoria.Descripcion = obtenerDescripcionC(item.Categoria.Id);
                }
            }


            return lista;
        }

        public string obtenerDescripcionM(int _id)
        {
            string consulta = "Select * from MARCAS where ID =" + _id;
            string auxDescripcion = "";
            AccesoDatos.setearConsulta(consulta);

            AccesoDatos.ejecutarLectura();
            if (AccesoDatos.Lector.Read()) // El Id es único, no hace falta ejecutar un while
                auxDescripcion = (string)AccesoDatos.Lector["Descripcion"];
            AccesoDatos.cerrarConexion();
            return auxDescripcion;
        }

        public string obtenerDescripcionC(int _id)
        {
            string consulta = "Select * from CATEGORIAS where ID =" + _id;
            string auxDescripcion = "";
            AccesoDatos.setearConsulta(consulta);

            AccesoDatos.ejecutarLectura();
            if (AccesoDatos.Lector.Read()) // El Id es único, no hace falta ejecutar un while
                auxDescripcion = (string)AccesoDatos.Lector["Descripcion"];
            AccesoDatos.cerrarConexion();
            return auxDescripcion;
        }
    }
}
