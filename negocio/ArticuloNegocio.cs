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
                string consulta = "Select A.Id Id, Codigo, IdCategoria, IdMarca, A.Descripcion Descripcion, Precio, Nombre, ImagenUrl, M.Descripcion Marca, C.Descripcion Categoria From ARTICULOS A, MARCAS M, CATEGORIAS C " + where;

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
                    articulo.Precio = (decimal)AccesoDatos.Lector["Precio"];
                    articulo.Marca = new Marca((int)AccesoDatos.Lector["IdMarca"], (string)AccesoDatos.Lector["Marca"]);
                    articulo.Categoria = new Categoria((int)AccesoDatos.Lector["IdCategoria"], (string)AccesoDatos.Lector["Categoria"]);
                    // Agrego en los constructores las descripciones, así nos ahorramos el foreach de getDescripciones
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
         // Borré el foreach porque hacía una iteración innecesaria, podemos traer directamente en la misma consulta todo
            return lista;
        }
        // Estos métodos no hacen falta, podemos traer directamente lo que necesitamos en la consulta y despues agregarlo en el constructor
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
            // Puse string template para hacerlo más prolijo
            
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
        public bool existeEnLaDb(string codigo)
        {
            List<Articulo> articulos = this.listar($"Where Codigo='{codigo}'");
            return articulos.Count >= 1;
        }
        public void eliminar(string codigo)
        {
            string consulta = $"Delete from ARTICULOS where Codigo='{codigo}'";
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
