<%@ Page Title="" Language="C#" MasterPageFile="~/SessionMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DoEasyWebProyect.FrmWelcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <div class="col-auto">
           <div style="border:solid 1px black; border-radius:20px; padding:20px;">

                  <asp:Button ID="BtnSignIn" CssClass="btn btn-success btn-lg align-self-center" runat="server" Text="Sign In" />
             
                   <asp:Button ID="BtnLogin" CssClass="btn btn-success btn-lg" runat="server" Text="Login" />
 
           </div>
        </div>
    
</asp:Content>
