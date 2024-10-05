using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;


namespace TpWeb_16B
{
    public partial class PromoWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TxtVacuher.Text = "Codigo voucher...";
        
        }



        protected void btnVaucher_Click(object sender, EventArgs e)
        {
            string codigoVaucher = TxtVacuher.Text.Trim();
            Vaucher voucher = new Vaucher();
            voucher.Codigo = codigoVaucher;
      
            ComercioVoucher comercioVoucher = new ComercioVoucher();

            string estado = comercioVoucher.verificarVaucher(voucher);
            if (estado == "Valido")
            {
                Session["codigoVoucher"] = codigoVaucher;
                Response.Redirect("Premios.aspx");
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



    
    }


}
