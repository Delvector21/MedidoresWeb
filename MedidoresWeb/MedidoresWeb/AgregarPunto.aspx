<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPunto.aspx.cs" Inherits="MedidoresWeb.AgregarPunto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

     <div class="row mt-5">
        <div class="col-md-4 col-lg-5 mx-auto">
            <div>
                <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
            </div>
            <div class="card col-8">
                <div class="card-header bg-success text-white text-center">
                    <h5>Registrar Punto de Carga</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="codigoTxt">Codigo</label>
                        <asp:TextBox runat="server" ID="codigoTxt" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row mb-3">
                        <label class="form-label" for="tipoRbl">Tipo</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Value="Electrico" Text="Eléctrico" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="Dual" Text="Dual"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="mb-3 col-4">
                        <label class="form-label"  for="capacidadTxt">Capacidad Máxima</label>
                        <asp:TextBox runat="server" type="number" ID="capacidadTxt" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="row mb-3">
                        <label class="form-label" for="fechaTxt">Fecha de Vencimiento</label>
                        <div class="col-2">
                             <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="img/calendar.png"
                            ImageAlign="AbsBottom"
                            Width="30px" Height="30px"
                            OnClick="ImageButton1_Click" />
                            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                            OnDayRender="Calendar1_DayRender"
                            Width="200px" Height="180px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                        </div>
                        <div class="col-4">
                            <asp:TextBox runat="server" ID="fechaTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        
                        
                       
                        
                    </div>
                </div>
                <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="ingresarBtn" CssClass="btn btn-dark" Text="Registrar"
                        OnClick="ingresarBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
