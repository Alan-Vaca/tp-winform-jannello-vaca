using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
      AccesoDatos AccesoDatos = new AccesoDatos("(local)\\SQLEXPRESS", "CATALOGO_DB");
      public List<Categoria> listar(string where)
      {
                List<Categoria> lista = new List<Categoria>();
                try
                {
                    AccesoDatos.cerrarConexion();
                    string consulta = "Select  * from CATEGORIAS" + where;

                    AccesoDatos.setearConsulta(consulta);
                    AccesoDatos.ejecutarLectura();
                    while (AccesoDatos.Lector.Read())
                    {
                        Categoria categoria = new Categoria((int)AccesoDatos.Lector["Id"], (string)AccesoDatos.Lector["Descripcion"]);
                        lista.Add(categoria);
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
    }

}
