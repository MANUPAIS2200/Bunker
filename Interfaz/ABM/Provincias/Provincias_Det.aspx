<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Provincias_Det.aspx.cs" Inherits="Interfaz.ABM.Provincias.Provincias_Det" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Provincias</h2>
            <ol class="breadcrumb">
                <li>ABM
                </li>
                <li class="active">
                    <strong>Modificar Provincia</strong></li>
            </ol>
        </div>
    </div>
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Modificar Provincia</h5>
                        <span class="pull-right">
                            <!-- BOTONES -->
                            <asp:Button Text="Modificar" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Modificar" OnClick="btn_Modificar_Click" ValidationGroup="AA" />
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
                                                            <label class="col-md-4 control-label mt-3">
                                                               Pais
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:DropDownList ID="DropDownListPais" AutoPostBack="true" runat="server"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                              <div class="panel-body">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label mt-3">
                                                               Descripcion
                                                            </label>
                                                            <div class="col-md-20">
                                                                <asp:TextBox runat="server" ID="TextDescripcion" CssClass="form-control" />
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
