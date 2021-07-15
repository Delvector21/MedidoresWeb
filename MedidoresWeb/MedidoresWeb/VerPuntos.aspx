<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPuntos.aspx.cs" Inherits="MedidoresWeb.VerPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando...</span>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <div class="row col-8 mt-5 mx-auto">
                <div class="mx-auto">
                <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
            </div>
                <div class="row col-2 mx-auto">
                    <asp:DropDownList ID="tipoDdl" runat="server"
                        AutoPostBack="true"
                        Enabled="false"
                        OnSelectedIndexChanged="tipoDdl_SelectedIndexChanged">
                        <asp:ListItem Value="Electrico" Text="Eléctrico"></asp:ListItem>
                        <asp:ListItem Value="Dual" Text="Dual"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:CheckBox ID="todosChx" class="mt-2" runat="server" Checked="true"
                        AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" Text="Ver Todos" />

                </div>
                <div class="mt-2">

                <asp:GridView ID="puntosGrid" runat="server"
                    AutoGenerateColumns="false" CssClass="table table-hover text-center table-dark" OnRowCommand="puntosGrid_RowCommand"
                    EmptyDataText="No hay Puntos en el sistema">
                    <Columns>
                        <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                        <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                        <asp:BoundField HeaderText="Capacidad Máxima" DataField="Capacidad" />
                        <asp:BoundField HeaderText="Fecha Vencimiento" DataField="Vidautil" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Eliminar" CssClass="btn btn-danger"
                                    CommandName="eliminar"
                                    CommandArgument='<%# Eval("Codigo")%>' />
                                 <asp:Button ID="Button2" runat="server" Text="Editar" CssClass="btn btn-info"
                                    CommandName="editar" 
                                    CommandArgument='<%# Eval("Codigo")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                    </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
