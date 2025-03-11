<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Data Generator</h1>
            <p class="lead">Clock on the button to create a grid of BOGUS information!</p>
            <p></p><asp:Button runat="server" ID="ButtonGenerate" Text="Generate Data" OnClick="ButtonGenerate_OnClick"/></p>
            <asp:GridView runat="server" ID="GridViewUsers" AutoGenerateColumns="True"></asp:GridView>
        </section>


    </main>

</asp:Content>
