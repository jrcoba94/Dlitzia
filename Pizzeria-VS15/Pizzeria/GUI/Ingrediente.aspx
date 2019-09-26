<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="Ingrediente.aspx.cs" Inherits="Pizzeria.GUI.Ingrediente" %>
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
            <h1 class="marbot15">Ingredientes</h1>
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
            <asp:GridView ID="gvIngredientes" runat="server" CssClass="filtrar" DataKeyNames="IdIngrediente" AutoGenerateColumns="False" CellSpacing="2" CellPadding="2">
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="IdIngrediente" Visible="false">
                        <HeaderStyle BackColor="#F4F4F4" BorderColor="#CCCCCC" BorderStyle="Solid" />
                        <ItemStyle BorderColor="#F0F0F0" BorderStyle="Solid" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre">
                        <HeaderStyle BackColor="#F4F4F4" BorderColor="#CCCCCC" BorderStyle="Solid" />
                        <ItemStyle BorderColor="#F0F0F0" BorderStyle="Solid" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion">
                        <HeaderStyle BackColor="#F4F4F4" BorderColor="#CCCCCC" BorderStyle="Solid" />
                        <ItemStyle BorderColor="#F0F0F0" BorderStyle="Solid" />
                    </asp:BoundField>
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

    <script>
        $(document).ready(function () {
            $(".filtrar tr:has(td)").each(function () {
                var t = $(this).text().toLowerCase();
                $("<td class='indexColumn'></td>")
                      .hide().text(t).appendTo(this);
            });

            $("#texto").keyup(function () {
                var s = $(this).val().toLowerCase().split(" ");
                $(".filtrar tr:hidden").show();
                $.each(s, function () {
                    $(".filtrar tr:visible .indexColumn:not(:contains('" + this + "'))").parent().hide();
                });
            });
        });
    </script>
</asp:Content>
