<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="CafeteriaRewards_Web.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="card">
        <div class="card-header bg-primary text-white">
            Ingresar Cliente
        </div>
        <div class="card-body">
            
            <div class="form-group">
                <label for="nombreTxt" >Nombre</label>
                <asp:TextBox ID="nombreTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Debe ingresar el nombre" CssClass="text-danger"
                    ControlToValidate="nombreTxt"
                    ></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="rutTxt">Rut</label>
                <asp:TextBox ID="rutTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="rutCV" runat="server" ErrorMessage="CustomValidator" CssClass="text-danger"
                    ControlToValidate="rutTxt" OnServerValidate="rutCV_ServerValidate" ValidateEmptyText="true"
                    ></asp:CustomValidator>
            </div>

            <div class="form-group">
                <label for="bebidaDdl">Bebida Favorita</label>
                <asp:DropDownList ID="bebidaDdl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>

        </div>

        <asp:Button ID="ingresarBtn" runat="server" Text="Crear Cliente" CssClass="btn btn-dark" onClick="ingresarBtn_Click"/>

    </div>


</asp:Content>
