<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmHome.aspx.cs" Inherits="DoEasyWebProyect.ClientForms.FrmHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <h1>Themes</h1>
        </div>
        <div class="col">
            <asp:Button ID="BtnAddTheme" OnClick="BtnAddTheme_Click" CssClass="btn btn-success" runat="server" Text="+" />
        </div>
    </div>
   <div class="row row-cols-1 row-cols-md-3 g-4">
      
     
       <asp:Repeater ID="RptThemeCard" runat="server">
            <ItemTemplate>
      <div class="col">
         
             
                   <div class="card text-bg-success mb-3" style="max-width: 18rem;">
                      <div class="card-header"><%#Eval("Title") %></div>
                       <i class="<%#Eval("Icon.Description") %>"></i>
                      <div class="card-body">
                        
                        <asp:Button ID="BtnThemeView" runat="server" Text="Go" CommandArgument='<%#Eval("Id")%>' OnClick="BtnThemeView_Click" />
                      </div>
                    </div>
             
      </div>
                 </ItemTemplate>
          </asp:Repeater>
    </div>
</asp:Content>
