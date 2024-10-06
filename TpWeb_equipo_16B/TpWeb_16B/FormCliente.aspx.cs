using negocio;
using System;
using dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace TpWeb_16B
{
    public partial class FormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptarForm_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            ComercioVoucher comercio = new ComercioVoucher();
            Cliente cliente1 = new Cliente();
            try
            {
                Cliente cliente = comercio.buscarPorDni(dni);
                if (cliente == null)
                {
                    cliente1.Dni = txtDni.Text;
                    cliente1.Nombre = txtNombre.Text;
                    cliente1.Apellido = txtApellido.Text;
                    cliente1.Email = txtEmail.Text;
                    cliente1.Direccion = txtDireccion.Text;
                    cliente1.Ciudad = txtCiudad.Text;
                    cliente1.CodigoPostal = int.Parse(txtCodigoPostal.Text);
                    comercio.AgregarClientes(cliente1);
                    Response.Redirect("Agradecimiento.aspx");
                }
                else
                {
                    Response.Redirect("Agradecimiento.aspx");
                }
                



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            ComercioVoucher comercio = new ComercioVoucher();
            Cliente cliente1 = new Cliente();
            try
            {
                Cliente cliente = comercio.buscarPorDni(dni);
                if (cliente != null)
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