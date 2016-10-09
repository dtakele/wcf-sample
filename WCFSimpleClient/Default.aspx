<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFSimpleClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>WCF Simple Client</h2>
            <p>
                Test client
            </p>
          
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:TextBox runat="server" placeholder="Enter your name" ID="txtName"/>
            <asp:Button CssClass="btn btn-primary" runat="server" Text="Say Hello" ID="btnSayHello" OnClick="btnSayHello_Click" /><br />
            <asp:Label runat="server" ID="lblResult" />
        </div>
        
    </div>

</asp:Content>
