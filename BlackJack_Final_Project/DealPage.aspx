<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DealPage.aspx.cs" Inherits="BlackJack_Final_Project.DealPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="/style/css/app.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container bg-hand pb-2 pt-2 shadow rounded">

            <div class="row">
                <div class="col-12 d-flex justify-content-center mt-5 mb-5">
                    <div class="justify-content-center">
                        <div>
                            <asp:Label ID="lblCurrentChipCount" runat="server" Text="Label" class="text-white mt-2" Font-Size="XX-Large"></asp:Label>
                        </div>
                        <%--<div><asp:Label ID="lblMinimumBet" runat="server" Text="Label"></asp:Label></div>--%>
                        <div>
                            <asp:Label ID="lblHand" runat="server" Text="Label" class="text-white mt-2" Font-Size="XX-Large"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lblBet" runat="server" Text="Bet: " class="text-white mt-2" Font-Size="XX-Large"></asp:Label>
                            <asp:Label ID="lblBetValue" runat="server" Text="lblBetValue" class="text-white mt-2" Font-Size="XX-Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-12 d-flex justify-content-center mt-5 mb-5">
                    <asp:LinkButton ID="btn1" runat="server"  Class="btn btn1 btn-circle mr-3" OnClick="btn1_Click">1</asp:LinkButton>
                    <asp:LinkButton ID="btn5" runat="server"  Class="btn btn5 btn-circle mr-3" OnClick="btn5_Click">5</asp:LinkButton>
                    <asp:LinkButton ID="btn25" runat="server"  Class="btn btn25 btn-circle mr-3" OnClick="btn25_Click">25</asp:LinkButton>
                    <asp:LinkButton ID="btn50" runat="server" Class="btn btn50 btn-circle mr-3" OnClick="btn50_Click">50</asp:LinkButton>
                    <asp:LinkButton ID="btn100" runat="server" Class="btn btn100 btn-circle mr-3" OnClick="btn100_Click">100</asp:LinkButton>
                    <asp:LinkButton ID="btn500" runat="server" Class="btn btn500 btn-circle mr-3" OnClick="btn500_Click">500</asp:LinkButton>
                </div>
            </div>
            <div class="row">
                <div class="col-12 d-flex justify-content-center mt-3">     
                    <asp:LinkButton ID="btnReset" runat="server" Class="btn btn-danger w-25" OnClick="btnReset_Click" >Reset Bet</asp:LinkButton>
                    <asp:LinkButton ID="btnEndGame" runat="server" Class="btn btn-danger w-25" OnClick="btnEndGame_Click" >End Game</asp:LinkButton>
                </div>
            </div>
            <div class="row">
                <div class="col-12 d-flex justify-content-center mt-3 mb-3">
                    <asp:LinkButton ID="btnBet" runat="server" OnClick="btnBet_Click" Class="btn btn-danger w-25">Deal</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
