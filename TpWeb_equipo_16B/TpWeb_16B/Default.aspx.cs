using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpWeb_16B
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ComercioArticulo negocio = new ComercioArticulo();
            ListaArticulos = negocio.listarConSP();
            repCardArt.DataSource = ListaArticulos;
            repCardArt.DataBind();
        }
    }
}