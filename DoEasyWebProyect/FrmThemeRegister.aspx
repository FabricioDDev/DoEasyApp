<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmThemeRegister.aspx.cs" Inherits="DoEasyWebProyect.FrmThemeRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
              <div class="row">
                <div class="col">

                    <nav class="navbar bg-dark" style=" border-radius: 0px 0px 10px 10px;">
                      <div class="container-fluid">
                        <a class="navbar-brand" style="color:white;">Do Easy!</a>
                        <form class="d-flex">
                            
                            <asp:Button ID="BtnBack" OnClick="BtnBack_Click" runat="server" Text="Button" />
                        </form>
                      </div>
                    </nav>
                </div>
       
            </div>
            <div class="row">
                <div class="col">
                    
                    <asp:TextBox ID="TextBox1" AutoPostBack="false"  runat="server"></asp:TextBox>
                    <asp:Label ID="LblIcon" runat="server" Text=""></asp:Label>
                    <div>
                        <asp:Repeater ID="RptIcon" runat="server">
                            <ItemTemplate>
                                <asp:LinkButton ID="LkbIcon" OnClick="LkbIcon_Click" CommandArgument='<%#Eval("Description") %>' CssClass='<%#Eval("Description") %>' runat="server"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    
                    <asp:Button ID="BtnFinish" OnClick="BtnFinish_Click" runat="server" Text="Button" />
                </div>
            </div>
        </div>
    </form>
     <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
    <script src="https://kit.fontawesome.com/65700b021d.js" crossorigin="anonymous"></script>
</body>
</html>
