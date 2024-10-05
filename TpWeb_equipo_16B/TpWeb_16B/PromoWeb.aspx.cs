using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace TpWeb_16B
{
    public partial class PromoWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtVacuher.Text = !IsPostBack ? "Codigo voucher..." : " ";

        }



        protected void btnVaucher_Click(object sender, EventArgs e)
        {
            string codigoVaucher = TxtVacuher.Text.Trim();
            Vaucher voucher = new Vaucher { Codigo = codigoVaucher };

            string estado = verificarVaucher(voucher);
            if (estado == "Valido")
            {
               
                Response.Redirect("Default.aspx");
            }
            else if (estado == "voucherCanjeado")
            {

                
                lblMessage.Text = "El voucher ya fue canjeado.";
            }
            else if (estado == "Invalido")
            {
       
                
                lblMessage.Text = "El código del voucher no es válido.";
            }
            else if (estado == "Error")
            {
                
               
                lblMessage.Text = "Ocurrió un error al verificar el voucher.";
            }

        }

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

    
    }


}
