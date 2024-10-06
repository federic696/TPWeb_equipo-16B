<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCliente.aspx.cs" Inherits="TpWeb_16B.FormCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row g-3 needs-validation">
        <div class="col-md-4">
            <label for="validationCustom00" class="form-label">Dni</label>
            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" OnTextChanged="txtDni_TextChanged" AutoPostBack="true" MinLength="8" MaxLength="8"
                pattern="\d{8,8}" title="El DNI debe contener solo números y  8 caracteres" required="required"></asp:TextBox>

        </div>
        <div class="col-md-4">
            <label for="validationCustom01" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Text="" pattern="[A-Za-z]+"
                title="El nombre solo debe contener letras" required="required"></asp:TextBox>

        </div>
        <div class="col-md-4">
            <label for="validationCustom02" class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Text="" pattern="[A-Za-z]+"
                title="El apellido solo debe contener letras" required="required"></asp:TextBox>

        </div>
        <div class="col-md-4">
            <label for="validationCustomUsername" class="form-label">Email</label>
            <div class="input-group has-validation">
                <span class="input-group-text" id="inputGroupPrepend">@</span>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text="" type="email"
                    title="Ingrese una dirección de correo válida" required="required"></asp:TextBox>

            </div>
        </div>
        <div class="col-md-6">
            <label for="validationCustom03" class="form-label">Direccion</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Text=""
                pattern="[A-Za-z0-9\s]+" title="La dirección debe contener letras y números" required="required"></asp:TextBox>
        </div>

    </div>
    <div class="col-md-3">
        <label for="validationCustom04" class="form-label">Ciudad</label>
        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" pattern="[A-Za-z\s]+"
            title="La ciudad solo debe contener letras" required="required"></asp:TextBox>
    </div>
    <div class="col-md-3">
        <label for="validationCustom05" class="form-label">Codigo Postal</label>
        <asp:TextBox ID="txtCodigoPostal" runat="server" CssClass="form-control"
            pattern="\d{1,6}" title="El código postal debe contener solo números y un máximo de 6 caracteres"
            MaxLength="6" required="required"></asp:TextBox>

    </div>
    <div class="col-12">
        <div class="form-check">
            <input class="form-check-input" type="checkbox" value="" id="invalidCheck" required>
            <label class="form-check-label" for="invalidCheck">
                Acepto los terminos y condiciones
            </label>
            <div class="invalid-feedback">
                You must agree before submitting.
            </div>
        </div>
    </div>
    <div class="col-12">
        <asp:Button ID="btnForm" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnAceptarForm_Click" />
    </div>


    <script src="JS/JavaScript.js"></script>
</asp:Content>

