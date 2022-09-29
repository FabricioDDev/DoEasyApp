<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmThemeViewV2.aspx.cs" Inherits="DoEasyWebProyect.FrmThemeViewV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
    
    <title></title>
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
                            
                            <asp:Button ID="BtnBack" OnClick="BtnBack_Click" CssClass="btn btn-success" runat="server" Text="Volver" />
                        </form>
                      </div>
                    </nav>
                </div>
       
            </div>

            <div class="row">
                <div class="col">
                    <h1>Nombre-Tema</h1>
                </div>
                <div class="col">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="+" />
                </div>
                <div class="col">
                     <asp:Button ID="BtnView" OnClick="BtnView_Click" CssClass="btn btn-success" runat="server" Text="Vista" />
                </div>
                <div class="col">
                     <asp:Button ID="Button5" CssClass="btn btn-success" runat="server" Text="Config" />
                </div>
            </div>
            <div class="row">
                <asp:GridView ID="GvNote" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
     <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>
</html>
