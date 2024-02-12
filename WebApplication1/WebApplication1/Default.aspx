<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <h2 class="text-center mb-4">Visualizza candidato</h2>
        <div class="row">
            <div class="col border border-1">
                <h4 class="text-center mt-2">Nome candidato</h4>
                <p ID="parNome" runat="server" class="text-center"></p>
            </div>
            <div class="col border border-1">
                <h4 class="text-center mt-2">Cognome candidato</h4>
                <p ID="parCognome" runat="server" class="text-center"></p>
            </div>
        </div>
        <div class="d-flex justify-content-center">
        <asp:Button ID="VisualizzaCandidato" class="btn btn-outline-info rounded-0 px-5 mt-3" runat="server" Text="Visualizza candidato" OnClick="VisualizzaCandidato_Click" />
        </div>


</asp:Content>
