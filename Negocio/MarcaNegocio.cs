using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
               datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion=(string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
            }
             
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;

        }
        public void agregar(Marca nueva) {

            AccesoDatos datos= new AccesoDatos ();

            try
            {
                datos.setearConsulta("INSERT INTO MARCAS(Descripcion) VALUES(@Descripcion)");
                datos.setearParametro("@Descripcion", nueva.Descripcion);
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

        public void modificar (Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE MARCAS SET Descripcion=@Descripcion WHERE Id=@Id");
                datos.setearParametro("@Descripcion", marca.Descripcion);
                datos.setearParametro("@Id", marca.Id); 

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

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update MARCAS set Activo = 0 Where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
