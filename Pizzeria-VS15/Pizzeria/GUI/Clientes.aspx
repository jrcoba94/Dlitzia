<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Pizzeria.GUI.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="card-panel">
        <h5 class="" >Clientes</h5>
        <div class="row">
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtNombre" runat="server" MaxLength="100" CssClass="validate"></asp:TextBox>
                    <label for="txtNombre">Nombre</label>
                </div>
            </div>
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtTelefono" MaxLength="10" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtTelefono">Teléfono</label>
                </div>
            </div>      
        </div>
        <div class="row">
            <div class="col s12 m12 l6">
                <div class="input-field">
                    <asp:TextBox ID="txtDireccion" MaxLength="100" runat="server" CssClass="validate"></asp:TextBox>
                    <label for="txtDireccion">Dirección</label>
                </div>
            </div>
        </div>
        <asp:Button OnClick="btnGuardar_Click" ID="btnGuardar" CssClass="black btn waves-effect waves-light" runat="server" Text="Guardar" />
    </div>
    <div class="card-panel">
        <h4>Lista productos</h4> 
        <asp:GridView ID="gvProductos" runat="server" CellPadding="4" CssClass="lighten-5 responsive-table" GridLines="None"
            DataKeyNames="IdCliente" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
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
