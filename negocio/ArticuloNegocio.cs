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
                string consulta = "Select  A.Id Id,A.Codigo,A.Nombre,A.Descripcion,M.Descripcion 'Marca',C.Descripcion 'Categoria'," +
                                    "A.ImagenUrl,A.Precio, A.IdMarca IdMarca, A.IdCategoria IdCategoria from Articulos A " +
                                    "inner join Marcas M on M.Id=A.IdMarca " +
                                    "inner join Categorias C on C.Id=A.IdCategoria " + where; 
                AccesoDatos.setearConsulta(consulta);
                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)AccesoDatos.Lector["Id"];
                    if (!(AccesoDatos.Lector["Codigo"] is DBNull))    
                        articulo.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
                    if (!(AccesoDatos.Lector["Nombre"] is DBNull))
                        articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    if (!(AccesoDatos.Lector["Descripcion"] is DBNull))
                        articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    if (!(AccesoDatos.Lector["ImagenUrl"] is DBNull))
                        articulo.URLimagen = (string)AccesoDatos.Lector["ImagenUrl"];
                    if (!(AccesoDatos.Lector["Precio"] is DBNull))
                        articulo.Precio = (decimal)AccesoDatos.Lector["Precio"];
                    if (!(AccesoDatos.Lector["Marca"] is DBNull))
                        articulo.Marca = new Marca((int)AccesoDatos.Lector["IdMarca"], (string)AccesoDatos.Lector["Marca"]);
                    if (!(AccesoDatos.Lector["Categoria"] is DBNull))
                        articulo.Categoria = new Categoria((int)AccesoDatos.Lector["IdCategoria"], (string)AccesoDatos.Lector["Categoria"]);
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

        public void agregar(Articulo art)
        {
            string consulta = "Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values(" +
                $"'{art.CodigoArticulo}', '{art.Nombre}', '{art.Descripcion}', {art.Marca.Id}, {art.Categoria.Id}, '{art.URLimagen}', {art.Precio})";
            try
            {
               AccesoDatos.setearConsulta(consulta);
               AccesoDatos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool existeEnLaDb(int id)
        {
            List<Articulo> articulos = this.listar($"Where A.Id='{id}'");
            return articulos.Count >= 1;
        }
        public bool chequearCodArticuloEnDb(string cod)
        {
            List<Articulo> articulos = this.listar($"Where Codigo='{cod}'");
            return articulos.Count >= 1;
        }
        public void eliminar(int id)
        {
            string consulta = $"Delete from ARTICULOS where Id='{id}'";
            try
            {
                AccesoDatos.setearConsulta(consulta);
                AccesoDatos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
