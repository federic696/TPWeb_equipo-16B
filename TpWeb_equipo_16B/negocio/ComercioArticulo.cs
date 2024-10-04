using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using datos;
using System.Xml.Linq;
namespace negocio
{
    public class ComercioArticulo
    {
        public List<Articulo> articuloListar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = PROMOS_DB; integrated security= true;";
                //conexion.ConnectionString = "server = localhost; database = CATALOGO_P3_DB; User Id=SA;Password=Panqueque16;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, i.ImagenUrl AS imagen, a.Id FROM ARTICULOS a LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl = lector["imagen"].ToString();
                    //Falta Agregar Marca y Categoria
                    listaArticulos.Add(aux);
                }
                conexion.Close();

                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public void agregar(Articulo nArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio)values(@Codigo, @Nombre, @Descripcion, @Precio)");
                datos.setearParametro("@Codigo", nArt.Codigo);
                datos.setearParametro("@Nombre", nArt.Nombre);
                datos.setearParametro("@Descripcion", nArt.Descripcion);
                datos.setearParametro("@Precio", nArt.Precio);

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

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio Where Id = @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.Id);

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


        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> listarConSP()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("listarArticulos");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["UrlImagen"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //FUNCIONES DE CATEGORIA 
        public List<Categoria> categoriaListar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security= true;";
                //conexion.ConnectionString = "server = localhost; database = CATALOGO_P3_DB; User Id=SA;Password=Panqueque16;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Descripcion, Id FROM CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Descripcion"];
                    listaCategoria.Add(aux);
                }
                conexion.Close();

                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }
        public void AgregarCategoria(Categoria Cat)
        {
            AccesoDatos Registro = new AccesoDatos();
            try
            {
                Registro.setearConsulta("INSERT into CATEGORIAS(Descripcion)values(@Descripcion);");
                Registro.setearParametro("@Descripcion", Cat.Nombre);

                Registro.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Registro.cerrarConexion();
            }
        }

        public void ModificarCategoria(Categoria Cat)
        {
            AccesoDatos Registro = new AccesoDatos();
            try
            {
                Registro.setearConsulta("update CATEGORIAS set Descripcion = @Descripcion Where Id = @id");
                Registro.setearParametro("@Descripcion", Cat.Nombre);
                Registro.setearParametro("@Id", Cat.Id);
                Registro.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Registro.cerrarConexion();
            }
        }

        ///FUNCIONES DE MARCAS
        public List<Marca> MarcasListar()
        {
            List<Marca> listaMarca = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security= true;";
                //conexion.ConnectionString = "server = localhost; database = CATALOGO_P3_DB; User Id=SA;Password=Panqueque16;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Descripcion, Id FROM MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Descripcion"];
                    listaMarca.Add(aux);
                }
                conexion.Close();

                return listaMarca;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public void AgregarMarca(Marca Mar)
        {
            AccesoDatos Registro = new AccesoDatos();
            try
            {
                Registro.setearConsulta("INSERT into MARCAS(Descripcion)values(@Descripcion);");
                Registro.setearParametro("@Descripcion", Mar.Nombre);

                Registro.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Registro.cerrarConexion();
            }
        }

        public void Modificarmarca(Marca Mar)
        {
            AccesoDatos Registro = new AccesoDatos();
            try
            {
                Registro.setearConsulta("update MARCAS set Descripcion = @Descripcion Where Id = @id");
                Registro.setearParametro("@Descripcion", Mar.Nombre);
                Registro.setearParametro("@Id", Mar.Id);
                Registro.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Registro.cerrarConexion();
            }
        }
        public void EliminarMarca(Marca Mar)
        {
            AccesoDatos Registro = new AccesoDatos();

            try
            {
                Registro.setearConsulta("DELETE FROM MARCAS where Id = @Id");
                Registro.setearParametro("@Id", Mar.Id);
                Registro.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Registro.cerrarConexion();
            }
        }
    }
}
