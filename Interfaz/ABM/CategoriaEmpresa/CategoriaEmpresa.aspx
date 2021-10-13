<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoriaEmpresa.aspx.cs" Inherits="Interfaz.ABM.CategoriaEmpresa.CategoriaEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Categorias Por Empresas</h2>
            <ol class="breadcrumb">
                <li>
                    ABM
                </li>
                <li class="active">
                    <strong>   Categorias Por Empresas  </strong></li>
            </ol>
        </div>
       </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Categorias Por Empresas</h5>
                        <div class="ibox-tools">
                        </div>
                        <!-- END TITULO -->
                    </div>

                    <div class="ibox-content">
                        <!-- CONTENIDO -->
                        <div class="row form-horizontal">
                            <div class="col-md-4  form-group">
                                <div class="col-md-12">
                                    <asp:Button Text="Agregar" ID="btn_Agregar" runat="server" CssClass="btn btn-primary" OnClick="btn_Agregar_Click" />
                                </div>
                            </div>
                        </div>

                        <div class="row form-horizontal">

                            <div class="col-md-12">

                                <div class="table table-responsive">

                                    <asp:GridView ID="grid_CategoriaEmpresa" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" GridLines="None"
                                         PageSize="10" Width="100%" AllowPaging="True" OnPageIndexChanging="grid_CategoriaEmpresa_PageIndexChanging"  >
                                         <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                   <asp:HyperLink NavigateUrl='<%# "CategoriaEmpresa_Det.aspx?id=" + Eval("ID").ToString() %>' runat="server">
                                                        <span class="fas fa-pencil-alt"></span>
                                                    </asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                               
                                                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                                             
                                        </Columns>
                                        <PagerStyle CssClass="pagination-ys" HorizontalAlign="Center"  />
                                    </asp:GridView>
                                </div>
                            </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
