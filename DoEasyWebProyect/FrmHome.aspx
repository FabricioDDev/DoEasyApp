<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmHome.aspx.cs" Inherits="DoEasyWebProyect.ClientForms.FrmHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            
                <h1>Themes</h1>
                <asp:Button ID="BtnAddTheme" CssClass="btn btn-success" runat="server" Text="+" />
            
        </div>
    </div>
   <div class="row row-cols-1 row-cols-md-3 g-4">
      
     
       <asp:Repeater ID="RptThemeCard" runat="server">
            <ItemTemplate>
      <div class="col">
         
             
                   <div class="card text-bg-success mb-3" style="max-width: 18rem;">
                      <div class="card-header">Header</div>
                      <div class="card-body">
                        <h5 class="card-title">Success card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                      </div>
                    </div>
             
      </div>
                 </ItemTemplate>
          </asp:Repeater>
    </div>
</asp:Content>
