<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pizzeria.GUI.Login"  EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>D`LIZIA</title>

    <link href="../PizzeriaMP/Login/css/materialize.min.css" rel="stylesheet" />
    <link href="../PizzeriaMP/Login/css/style.min.css" rel="stylesheet" />
    <link href="../PizzeriaMP/Login/css/page-center.css" rel="stylesheet" />
    <link href="../PizzeriaMP/Login/css/perfect-scrollbar.css" rel="stylesheet" />
    <link href="../PizzeriaMP/Login/css/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
    <br />
    <br />
    <div class="section">
        <div id="login-page" class="row">
            <div class="col s12 z-depth-4 card-panel">
                <form class="login-form">
                    <div class="row">
                        <div class="input-field col s12 center">
                            <img src="../PizzeriaMP/Login/img/DLIZIA_logo3.png" alt="" class="responsive-img valign"/>
                        </div>
                    </div>
                    <div class="row margin">
                        <div class="input-field col s12">
                            <i class="fa fa-user prefix"></i>
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="validate" AutoCompleteType="Disabled"></asp:TextBox>
                            <label for="username" class="center-align">Usuario</label>
                        </div>
                    </div>
                    <div class="row margin">
                        <div class="input-field col s12">
                            <i class="fa fa-lock prefix"></i>
                            <asp:TextBox ID="txtContrasena" runat="server" CssClass="validate" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
                            <label for="password">Contraseña</label>
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="input-field col s12">
                            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" CssClass="btn black white-text btn-block waves-effect waves-light" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    </form>
    <br />

    <script src="../PizzeriaMP/Login/js/jquery-2.1.4.min.js"></script>
    <script src="../PizzeriaMP/Login/js/materialize.min.js"></script>
    <script src="../PizzeriaMP/Login/js/perfect-scrollbar.min.js"></script>
</body>
</html>
