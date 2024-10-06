<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpWeb_16B.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="content/Styles.css" rel="stylesheet" />
    <main>
        <div class="Carrusel">
            <div id="carouselExampleIndicators" class="carousel slide " data-bs-ride="carousel">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="3" aria-label="Slide 4"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="4" aria-label="Slide 5"></button>
                </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://www.gamespot.com/a/uploads/original/1595/15950357/4113239-bestcontrollers.jpg" class="d-block w-100 " alt="..." id="CarruselImagen">
                    </div>
                    <div class="carousel-item">
                        <img src="https://i.blogs.es/01e39b/img_2221/1366_2000.jpeg" class="d-block w-100" alt="..." id="CarruselImagen">
                    </div>
                    <div class="carousel-item">
                        <img src="https://gizmodo.uol.com.br/wp-content/blogs.dir/8/files/2021/02/lenovo-legion-phone-duel.jpg" class="d-block w-100" alt="..." id="CarruselImagen">
                    </div>
                    <div class="carousel-item">
                        <img src="https://image.benq.com/is/image/benqco/ex2710s-2product?$ResponsivePreset$&wid=1000&dpr=off" class="d-block w-100" alt="..." id="CarruselImagen">
                    </div>
                    <div class="carousel-item">
                        <img src="https://www.dekada.com/en/images/cm_406_5product_promotion_c5bmMN.jpg" class="d-block w-100" alt="..." id="CarruselImagen">
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
        </div>

        <div class="TituloInicio">
            <h1>PROMO CYBER FEST</h1>
        </div>
        <div class="productos-cont" id="ParrafoI">
            <h2 class="ParrafoInicio">PARTICIPA Y INGRESA CODIGOS OCULTOS EN NUESTRA PAGINA QUE PODRAS GANAR ESTOS INCREIBLES PRODUCTOS</h2>
        </div>
        <hr />
        <div class="card-group" id="CartasProductos">
            <asp:Repeater runat="server" ID="repCardArt">
                <ItemTemplate>
                    <div class="card" style="width: 20rem;">
                        <div class="ContenedorImagen">
                            <img src="<%#Eval("imagenUrl") %>" class="card-img-top" alt="..." id="ImagenCarta">
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <div class="d-md-flex justify-content-md-center" id="BotonParticipa">
            <a class="btn btn-primary " href="PromoWeb.aspx" role="button" id="Participalink">Participa!!</a>
        </div>

    </main>
</asp:Content>
