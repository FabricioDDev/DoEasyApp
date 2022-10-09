<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmThemeView.aspx.cs" Inherits="DoEasyWebProyect.FrmThemeView" %>

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
                     <asp:Button ID="BtnView" OnClick="BtnView_Click"  CssClass="btn btn-success" runat="server" Text="Vista" />
                </div>
                <div class="col">
                     <asp:Button ID="BtnConfig" OnClick="BtnConfig_Click" CssClass="btn btn-success" runat="server" Text="Config" />
                </div>
            </div>



           <div class="row row-cols-1 row-cols-md-3 g-4">

               <asp:Repeater ID="RptNote" runat="server">
                   <ItemTemplate>
                        <div class="col">
                           <div class="card text-bg-success mb-3" style="max-width: 18rem;">
                              <div class="card-header"><%#Eval("Title")%></div>
                              <div class="card-body">
                                <h5 class="card-title"><%#Eval("Description") %></h5>
                                  <asp:Button ID="Button2" runat="server" Text="M" />
                                  <asp:Button ID="Button3" runat="server" Text="D" />
                              </div>
                            </div>
                          </div>
                   </ItemTemplate>
               </asp:Repeater>
             
            </div>
        </div>
    </form>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>
</html>
