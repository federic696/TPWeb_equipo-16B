<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpWeb_16B.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="content/Styles.css" rel="stylesheet" />
    <main>
        <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="https://photos5.appleinsider.com/gallery/product_pages/113-hero.jpg" class="d-block w-100 " alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://i.blogs.es/01e39b/img_2221/1366_2000.jpeg" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://duet-cdn.vox-cdn.com/thumbor/0x0:2040x1360/2400x1600/filters:focal(1020x680:1021x681):format(webp)/cdn.vox-cdn.com/uploads/chorus_asset/file/24648952/asus_rog_ally_vjeran_pavic_the_verge_007.jpg" class="d-block w-100" alt="...">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>


        <div class="TituloInicio">
            <h1>Promo cyber fest</h1>
        </div>
        <div class="productos-cont">

            <h2>Ingresa y particima ingresando nuestro codigo para ganar los siguientes productos</h2>
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
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
        <div class="d-md-flex justify-content-md-center" id="BotonParticipa">
            <a class="btn btn-primary" href="PromoWeb.aspx" role="button">Participa!!</a>
        </div>
    </main>
</asp:Content>
