<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HandPage.aspx.cs" Inherits="BlackJack_Final_Project.HandPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="/style/css/app.css" />

</head>
<body>

    <form id="form1" runat="server">
    <div class="container bg-hand pb-2 pt-2 shadow rounded">

        <div class="row">
            <div class="col-12 d-flex justify-content-around mt-5 mb-5">
                <asp:Label ID="lblBank" runat="server" Text="lblBank" class="text-white" Font-Size="XX-Large"></asp:Label>
                <asp:Label ID="lblWins" runat="server" Text="lblWins" class="text-white" Font-Size="XX-Large"></asp:Label>
                <asp:Label ID="lblRound" runat="server" Text="lblRound" class="text-white" Font-Size="XX-Large"></asp:Label>
            </div>   
        </div>

        <div class="row">
            <div class="col-12 d-flex justify-content-center">
                <asp:Label ID="lblDealerHand" runat="server" Text="lblPlayerHand" ForeColor="White" Font-Size="X-Large"></asp:Label>
            </div>
        </div>
        
        <div class="row mt-3">
            <div class="col-12 d-flex justify-content-center pl">
                <ul class="list-group list-group-horizontal" runat="server" id="dealerCards" style="list-style-type:none"> 
                </ul>    
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-12 d-flex justify-content-center">
                <asp:Label ID="lblDealerHandValue" runat="server" Text="lblPLayerHandValue" class="btn-circle"></asp:Label>
            </div>
        </div>

         <div class="row">
            <div class="col-12 col-sm-10 col-lg-12 mx-auto">
                <div class="d-flex justify-content-around mt-5 mb-5">
                    <asp:LinkButton ID="btnHit" runat="server" OnClick="btnHit_Click" Class="btn btn-danger w-25" Font-Size="X-Large">Hit</asp:LinkButton>
                    <asp:Label ID="lblShowBet" runat="server" Text="lblShowBet" ForeColor="White" Font-Size="XX-Large">></asp:Label>
                    <asp:LinkButton ID="btnStand" runat="server" OnClick="btnStand_Click" Class="btn btn-danger w-25" Font-Size="X-Large">Stand</asp:LinkButton>
                    <asp:Label ID="lblMessage" runat="server" ForeColor="White" Font-Size="XX-Large"></asp:Label>
                    <asp:LinkButton ID="btnOK" runat="server" OnClick="btnOK_Click" Class="btn btn-danger w-25" Font-Size="X-Large">OK</asp:LinkButton>
                </div>
            </div>
        </div>
 
        <div class="row mb-3">
            <div class="col-12 d-flex justify-content-center">
                <asp:Label ID="lblPlayerHand" runat="server" Text="lblPlayerHand" ForeColor="White" Font-Size="X-Large"></asp:Label>
            </div>
        </div>

        <div class="row ">
            <div class="col-12 d-flex justify-content-center pl">
                <ul class="list-group list-group-horizontal" runat="server" id="playerCards" style="list-style-type:none"> 
                </ul>    
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-12 d-flex justify-content-center">
                <asp:Label ID="lblPlayerHandValue" runat="server" Text="lblPLayerHandValue" class="btn-circle"></asp:Label>
            </div>
        </div>
    </div>
</form>

</body>
</html>
