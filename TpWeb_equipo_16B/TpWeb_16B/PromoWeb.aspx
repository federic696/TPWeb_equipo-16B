<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromoWeb.aspx.cs" Inherits="TpWeb_16B.PromoWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container d-flex justify-content-center" id="ParrafoI">
        <div class="col-md-6 col-sm-8 w-50" >
            <div class="mb-3">
                <asp:Label ID="Label1" runat="server" CssClass="form-label" Text="Ingresa el Código de tu voucher"></asp:Label>
                <asp:TextBox ID="TxtVacuher" runat="server" CssClass="form-control" Text="" onfocus="eliminarTexto(this)"></asp:TextBox>

            </div>
            <asp:Button ID="btnVaucher" runat="server" CssClass="btn btn-primary" Text="Siguiente" OnClick="btnVaucher_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="form-label"></asp:Label>
        </div>
    </div>
    <script src="JS/JavaScript.js"></script>

</asp:Content>




