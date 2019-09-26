<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="Pizza.aspx.cs" Inherits="Pizzeria.GUI.Pizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Banner" ContentPlaceHolderID="inicio" runat="server">
    <!-- Home Slider Banner -->
    <div id="inicio" class="sub-banner">
        <div class="parallax-container">
            <div class="parallax">
                <img src="../PizzeriaMP/MasterPage/img/Terraza.png" class="fullwidth" alt="" style="bottom: -53.6px; display: block;" />
            </div>
        </div>
        <!-- Banner Logo -->
        <div class="banner-text wow fadeInUp animated animated" data-wow-delay="300ms" style="visibility: visible; animation-delay: 300ms; animation-name: fadeInUp;">
            <h1 class="marbot15">Pizzas</h1>
            <div class="hr-line"><a href="#grid"><i class="fa fa-arrow-circle-down"></i></a></div>
            <div class="tag padding-12-per center">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn-large red white-text" OnClick="btnAgregar_Click" />
            </div>
        </div>
        <!-- // Banner Logo -->
    </div>
    <!-- // Home Slider Banner -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section"></div>
    <br />
    <br />
    <div class="section card-content">
        <div class="row col s12">
            <div class="input-field">
                <a class="fa fa-search prefix"></a>
                <input type="text" id="texto" name="FilterTextBox" autocomplete="off" />
            </div>
        </div>
    </div>
    <div class="section"></div>
    <br />
    <br />
    <br />
    <div id="grid" class="section">
        <div class="col s12">
            <asp:GridView ID="gvPizzas" CssClass="filt" runat="server" AutoGenerateColumns="false" CellSpacing="2" CellPadding="2">
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="IdPizza" Visible="false" />
                    <asp:BoundField HeaderText="Tamaño" DataField="Tamanio" />
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Precio" DataField="Precio" DataFormatString="{0:$ 0.0}" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="section"></div>

    <script lang="javascript" type="text/javascript">
        $(document).ready(function () {
            $('.filt tr:has(td)').each(function () {
                var t = $(this).text().toLowerCase();
                $('<td class="indexColumn"></td>').hide().text(t).appendTo(this);
            });

            $('#texto').keyup(function () {
                var s = $(this).val().toLowerCase().split(' ');
                $('.filt tr:hidden').show();
                $.each(s, function () {
                    $('.filt tr:visible .indexColumn:not(:contains(' + this + '))').parent().hide();
                });
            });
        });
    </script>
</asp:Content>
