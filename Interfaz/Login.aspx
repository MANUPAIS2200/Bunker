<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Interfaz.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="signup-form">
        <form action="/examples/actions/confirmation.php" method="post">
            <h2>Acceder</h2>
            <p class="hint-text">A continuación ingrese su Usuario y Contraseña.</p>
            <div class="form-group">
                <input type="text" class="form-control" name="usuario" placeholder="Usuario" required="required">
            </div>
            <div class="form-group">
                <input type="password" class="form-control" name="contraseña" placeholder="Contraseña" required="required">
            </div>
            <div class="form-group">
                <asp:Button type="submit" class="btn btn-success btn-lg btn-block" runat="server" OnClick="Unnamed_Click" Text="Ingresar" />
            </div>
        </form>

        <div class="text-center">Olvidaste tu contraseña? <a class="text-info li-modal" href="">Recuperar Contraseña</a></div>

    </div>
</asp:Content>
