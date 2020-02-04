<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BlackJack_Final_Project._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="/style/css/app.css" />

</head>
<body>
    <form id="form1" runat="server">   
        <div class="container bg-ini pb-2 pt-2 shadow rounded">

            <div class="row">
                <div class="col-12 d-flex justify-content-center mt-5 mb-5">
                    <div class="pad justify-content-center">
                        <div> 
                            <asp:Label ID="lblName" runat="server" Text="Your name:" class="text-white mt-2" Font-Size="XX-Large"></asp:Label>
                        </div>
                        <div class="mt-2"> 
                            <asp:TextBox ID="txtName" runat="server" class="justify-content-center"></asp:TextBox>
                        </div>
                        <div class="mt-2"> 
                            <asp:Button ID="btnPlay" runat="server" Text="Play" OnClick="btnPlay_Click" Class="btn btn-danger w-100" />
                        </div>
                     </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
