<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="MedidoresWeb.AgregarEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="card col-4 mt-5 mx-auto">
        <div class="card-header bg-primary text-white text-center">
            <h5>Ingresar Estacion</h5>
        </div>
        <div class="card-body">

            <div class="form-group">
                <label for="codigoTxt">Codigo</label>
                <asp:TextBox ID="codigoTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Debe ingresar un codigo" CssClass="text-danger"
                    ControlToValidate="codigoTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="direccionTxt">Direccion</label>
                <asp:TextBox ID="direccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ErrorMessage="Debe ingresar la direccion" CssClass="text-danger"
                    ControlToValidate="direccionTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="capacidadTxt">Capacidad Maxima de Autos</label>
                <asp:TextBox type="number" ID="capacidadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ErrorMessage="Debe ingresar la Capacidad" CssClass="text-danger"
                    ControlToValidate="capacidadTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="ciudadTxt">Ciudad</label>
                <asp:TextBox ID="ciudadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ErrorMessage="Debe ingresar una ciudad" CssClass="text-danger"
                    ControlToValidate="ciudadTxt"></asp:RequiredFieldValidator>
            </div>


            <div class="form-group">
                <label for="regionesDdl">Region</label>
                <asp:DropDownList ID="regionesDdl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>



        </div>
        <div class="card-footer d-grid gap-1">
            <asp:Button runat="server" ID="ingresarBtn" CssClass="btn btn-dark" Text="Registrar"
                OnClick="ingresarBtn_Click" />


        </div>
    </div>
</asp:Content>
