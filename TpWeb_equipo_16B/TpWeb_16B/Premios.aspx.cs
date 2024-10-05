
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace TpWeb_16B
{
    public partial class Premios : System.Web.UI.Page
    {
        private string codigoVoucher;
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ComercioArticulo negocio = new ComercioArticulo();
                ListaArticulos = negocio.listarConSP();
                repCardArt.DataSource = ListaArticulos;
                repCardArt.DataBind();
                

            }

       

        }

        protected void btnPremio_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idArticulo = Convert.ToInt32(btn.CommandArgument);
            codigoVoucher = (string)Session["codigoVoucher"];
            Vaucher voucher = new Vaucher();
            voucher.Codigo = codigoVoucher;
            voucher.IdCliente = 1;
            voucher.FechaCanje = DateTime.Now;
            voucher.IdArticulo = idArticulo;

            ComercioVoucher comercio = new ComercioVoucher();
            comercio.voucherCanjeado(voucher);
        }
    }
}