<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TpWeb_16B.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="productos-cont">
        <h2>Selecciona tu premio</h2>
        <hr />
    </div>
    <div class="card-cont">
        <asp:Repeater runat="server" ID="repCardArt">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                    <img src="<%#Eval("imagenUrl") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %></p>
                        <asp:Button ID="btnPremio" Text ="Seleccionar" CssClass="btn btn-primary" runat="server" OnClick="btnPremio_Click" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
