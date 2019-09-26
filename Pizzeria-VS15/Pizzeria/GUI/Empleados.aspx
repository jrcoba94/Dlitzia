<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Pizzeria.GUI.Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-panel">
        <h5 class="" >Empleados</h5>
        <div class="row">
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtNombre" runat="server" MaxLength="100" CssClass="validate"></asp:TextBox>
                    <label for="txtNombre">Nombre</label>
                </div>
            </div>
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtDireccion" MaxLength="100" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtDireccion">Dirección</label>
                </div>
            </div>      
        </div>
        <div class="row">
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtUsuario" MaxLength="100" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtUsuario">Usuario</label>
                </div>
            </div>
            <div class="col s12 m12 l6">
                <div class="input-field">
                <asp:DropDownList ID="ddlPizzerias" CssClass="browser-default" runat="server">
                </asp:DropDownList>
                </div>

            </div>
        </div>
        <div class="row">
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtContrasenia" MaxLength="23" type="password" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtContrasenia">Contraseña</label>
                </div>
            </div>
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtConfirmar" MaxLength="23" type="password" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtConfirmar">Confirmar contraseña</label>
                </div>
            </div>
        </div>
        <asp:Button OnClick="btnGuardar_Click" ID="btnGuardar" CssClass="black btn waves-effect waves-light" runat="server" Text="Guardar" />
    </div>
    <div class="card-panel">
        <h4>Lista Empleados</h4> 
        <asp:GridView ID="gvProductos" runat="server" CellPadding="4" CssClass="lighten-5 responsive-table" GridLines="None"
            DataKeyNames="IdEmpleado" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                <asp:BoundField DataField="IdPizzeria" HeaderText="IdPizzeria" />
                <asp:TemplateField HeaderText="Eliminar">
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" Text="Eliminar"
                            OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CssClass="btn btn-flat" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:HiddenField runat="server" ID="HiddenId" />
</asp:Content>
