<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEstaciones.aspx.cs" Inherits="MedidoresWeb.VerEstaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

   
       


            
            <div class="col-8 mt-5 mx-auto">

                <asp:GridView ID="estacionesGrid" runat="server"
                    AutoGenerateColumns="false" CssClass="table table-hover border-info" OnRowCommand="estacionesGrid_RowCommand"
                    EmptyDataText="No hay estaciones registradas">
                    <Columns>
                        <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                        <asp:BoundField HeaderText="Capacidad Maxima" DataField="Capacidad" />
                        <asp:BoundField HeaderText="Ciudad" DataField="Ciudad" />
                        <asp:BoundField HeaderText="Region" DataField="Region" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Eliminar"
                                    CssClass="btn btn-danger" CommandName="eliminar"
                                    CommandArgument='<%# Eval("Codigo") %>' />


                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>



            </div>
       
    















</asp:Content>
