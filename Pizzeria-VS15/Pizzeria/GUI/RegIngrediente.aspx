<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="RegIngrediente.aspx.cs" Inherits="Pizzeria.GUI.RegIngrediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <div class="section center-block">
        <div class="col s12 center">
            <h4>Registrar Ingrediente</h4>
        </div>
        <br />
        <div class="row">
            <div class="col s2"></div>
            <div class="col s8 z-depth-4">
                <div class="">
                    <div class="input-field">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        <label for="first_name">Nombre</label>
                    </div>
                    <div class="input-field">
                        <label>Descripción</label><br />
                        <br />
                        <textarea id="txtDescripcion" runat="server" cols="20" rows="2" style="height:150px"></textarea>
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
