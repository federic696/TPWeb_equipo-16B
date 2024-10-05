using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using dominio;

namespace negocio
{
    public class ComercioVoucher
    {
        public string verificarVaucher(Vaucher codigoVaucher)
        {
            string estado = "Invalido";
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @codigoVaucher");
                datos.setearParametro("@codigoVaucher", codigoVaucher.Codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int? idCliente = datos.Lector.IsDBNull(0) ? (int?)null : datos.Lector.GetInt32(0);
                    DateTime? fechaCanje = datos.Lector.IsDBNull(1) ? (DateTime?)null : datos.Lector.GetDateTime(1);
                    int? idArticulo = datos.Lector.IsDBNull(2) ? (int?)null : datos.Lector.GetInt32(2);

                    if (idCliente != null && fechaCanje != null && idArticulo != null)
                    {
                        estado = "voucherCanjeado";
                    }
                    else
                    {
                        estado = "Valido";
                    }
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



            return estado;
        }

        public void voucherCanjeado(Vaucher nVoucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                if (string.IsNullOrEmpty(nVoucher.Codigo))
                {
                    throw new Exception("El código del voucher no puede estar vacío.");
                }
                datos.setearConsulta("UPDATE Vouchers SET IdCliente = @idCliente, FechaCanje = @fechaCanje, IdArticulo = @idArticulo WHERE CodigoVoucher = @codigoVoucher");
                datos.setearParametro("@codigoVoucher", nVoucher.Codigo);
                datos.setearParametro("@idCliente", nVoucher.IdCliente);
                datos.setearParametro("@fechaCanje", nVoucher.FechaCanje);
                datos.setearParametro("@idArticulo", nVoucher.IdArticulo);


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
