using negocio;
using System;
using dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpWeb_16B
{
    public partial class FormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            ComercioVoucher comercio = new ComercioVoucher();

            try
            {   
                Cliente cliente = comercio.buscarPorDni(dni);
                if(cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtEmail.Text = cliente.Email;
                    txtDireccion.Text = cliente.Direccion;
                    txtCiudad.Text = cliente.Ciudad;
                    txtCodigoPostal.Text = cliente.CodigoPostal.ToString();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}