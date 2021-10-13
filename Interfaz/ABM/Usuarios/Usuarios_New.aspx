<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios_New.aspx.cs" Inherits="Interfaz.ABM.Usuarios.Usuarios_New" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Usuarios</h2>
            <ol class="breadcrumb">
                <li>ABM
                </li>
                <li class="active">
                    <strong>Agregar Usuarios</strong></li>
            </ol>
        </div>
    </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Agregar Usuarios</h5>
                        <span class="pull-right">
                            <!-- BOTONES -->
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Agregar" OnClick="btn_Agregar_Click" ValidationGroup="AA" />
                            <asp:Button Text="Volver" runat="server" CssClass="btn btn-success btn-sm" ID="btn_Volver" OnClick="btn_Volver_Click" />
                        </span>

                        <!-- END TITULO -->
                    </div>
                    <div class="ibox-content">
                        <!-- CONTENIDO -->

                        <div id="Tabs" role="tabpanel">
                            <div class="tab-content">
                                <div id="tab-1" class="tab-pane active" role="tabpanel">
                                    <div class="slimScrollDiv" style="position: relative; overflow: hidden; width: auto; height: 100%;">
                                        <div class="full-height-scroll" style="overflow: hidden; width: auto; height: 100%;">
                                            <div class="row form-horizontal">
                                                  <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                                Nick
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:TextBox runat="server" ID="Text_Nick" CssClass="form-control" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                                Contraseña
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:TextBox runat="server" ID="Text_Contraseña" CssClass="form-control" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                                Mail
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:TextBox runat="server" ID="Text_Mail" CssClass="form-control" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                               Contacto
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:DropDownList ID="DropDownListContactos" runat="server"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                              Departamento
                                                            </label>
                                                            <div class="col-md-20">
                                                               <asp:DropDownList ID="DropDownListDepartamentos" runat="server"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">
                                                               Permiso
                                                            </label>
                                                            <div class="col-md-20">
                                                               <asp:DropDownList ID="DropDownListPermisos" runat="server"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
