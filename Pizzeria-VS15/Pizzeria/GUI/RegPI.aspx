<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="RegPI.aspx.cs" Inherits="Pizzeria.GUI.RegPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <div class="section center-block">
        <div class="col s12 center">
            <h4>Registrar Pizza - Ingrediente</h4>
        </div>
        <br />
        <div class="row">
            <div class="col s2"></div>
            <div class="col s8 z-depth-4">
                <div class="">
                    <div class="input-field">
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                        <label for="first_name">Cantidad</label>
                    </div>
                    <div class="input-field">
                        <asp:TextBox ID="txtMedida" runat="server"></asp:TextBox>
                        <label for="first_name">Medida</label>
                    </div>
                    <div class="input-field">
                        <label for="first_name">Pizza:</label><br />
                        <asp:DropDownList ID="ddlPizzas" runat="server" DataSourceID="sdsPizzeria" DataTextField="Nombre" DataValueField="IdPizza"></asp:DropDownList>
                        <asp:SqlDataSource ID="sdsPizzeria" runat="server" ConnectionString="<%$ ConnectionStrings:PizzeriaConnectionString %>" SelectCommand="SELECT * FROM [Pizza]"></asp:SqlDataSource>
                    </div>
                    <div class="input-field">
                        <label for="first_name">Ingredientes:</label><br />
                        <asp:CheckBoxList ID="cblIngredientes" runat="server" DataSourceID="sdsIngredientes" DataTextField="Nombre" DataValueField="IdIngrediente"></asp:CheckBoxList>
                        <asp:SqlDataSource ID="sdsIngredientes" runat="server" ConnectionString="<%$ ConnectionStrings:PizzeriaConnectionString %>" SelectCommand="SELECT * FROM [Ingrediente]"></asp:SqlDataSource>
                    </div>
                    <br />
                    <br />
                    <div class="col s12">
                        <div class="col s6 center">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn red waves-effect waves-light responsive-img" OnClick="btnGuardar_Click"/>
                        </div>
                        <div class="col s6 center">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn red waves-effect waves-light responsive-img" OnClick="btnCancelar_Click"/>
                        </div>
                    </div>
                    <br />
                    <br />
                </div>
                <br />
                <br />
            </div>
            <div class="col s2"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="section"></div>
</asp:Content>
