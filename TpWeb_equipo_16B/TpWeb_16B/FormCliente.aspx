<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCliente.aspx.cs" Inherits="TpWeb_16B.FormCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row g-3 needs-validation">
        <div class="col-md-4">
            <label for="validationCustom00" class="form-label">Dni</label>
            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
           
        </div>
        <div class="col-md-4">
            <label for="validationCustom01" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Text="></asp:TextBox>
            
        </div>
        <div class="col-md-4">
            <label for="validationCustom02" class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
           
        </div>
        <div class="col-md-4">
            <label for="validationCustomUsername" class="form-label">Email</label>
            <div class="input-group has-validation">
                <span class="input-group-text" id="inputGroupPrepend">@</span>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
        </div>
        <div class="col-md-6">
            <label for="validationCustom03" class="form-label">Direccion</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

    </div>
    <div class="col-md-3">
        <label for="validationCustom04" class="form-label">Ciudad</label>
        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="col-md-3">
        <label for="validationCustom05" class="form-label">Codigo Postal</label>
        <asp:TextBox ID="txtCodigoPostal" runat="server" CssClass="form-control"></asp:TextBox>

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
        <button class="btn btn-primary" type="submit">Participar</button>
    </div>
  
    <script src="JS/JavaScript.js"></script>
</asp:Content>

