<%@ Page Title="" Language="C#" MasterPageFile="~/SessionMaster.Master" AutoEventWireup="true" CodeBehind="FrmSignIn.aspx.cs" Inherits="DoEasyWebProyect.FrmSignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="col-auto">
           <div style="border:solid 1px black; border-radius:20px; padding:20px;">

                  <form>
                      <div class="mb-3">
                        <label class="form-label">Your UserName or Mail*</label>
                        <asp:TextBox ID="TxtUser" CssClass="form-control" runat="server"></asp:TextBox>
                        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                      </div>
                      
                      <div class="mb-3">
                        <label class="form-label">Your Password*</label>
                         <asp:TextBox ID="TxtPass" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                      <div class="mb-3">
                           <asp:LinkButton ID="LbLogin" OnClick="LbLogin_Click"  runat="server">Already Have a account?</asp:LinkButton>
                      </div>

                      <asp:Button ID="BtnGo" OnClick="BtnGo_Click" CssClass="btn btn-primary" runat="server" Text="Go" />
                    </form>
 
           </div>
        </div>
</asp:Content>
