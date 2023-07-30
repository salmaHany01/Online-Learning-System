<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="OnlineLearningSystem.PaymentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment</title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 259px;
            text-align: left;
            justify-content:left;
        }
        #payment_btn {
            width: 176px;
            height: 34px;
            background-color: #A0D8B3;
        }
        .form_container {
            text-align:left;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="PaymentPanel" runat="server" EnableTheming="True" GroupingText="Payment Form" Height="330px" HorizontalAlign="Left" Width="857px" CssClass="auto-style2">
                &nbsp;<br />
                
                <br />
                <asp:Label runat="server" Text="Card Number"></asp:Label>
                <br />
                <asp:TextBox runat="server" id="card_number"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" Text="Expiry Month"></asp:Label>
                <br />
                <asp:TextBox runat="server" id="expiry_month"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" Text="Expiry Year"></asp:Label>
                <br />
                <asp:TextBox runat="server" id="expiryYear"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" Text="CVV"></asp:Label>
                <br />
                <asp:TextBox runat="server" id="security_code"></asp:TextBox>  
                <br />
                <br />
                <asp:Label runat="server" Text="Card holder name"></asp:Label>
                <br />
                <asp:TextBox runat="server"></asp:TextBox>  
                <br />
                <br />
    
                
                <asp:Button ID="payment_btn" runat="server" Text="Pay" OnClick="payment_btn_Click"></asp:Button>
                <br />
                <br />
                <asp:Label ID="error_lbl" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Incorrect input." Visible="False"></asp:Label>

               
        </asp:Panel>
            <asp:Panel ID="success_pay_panel" runat="server" EnableTheming="True" GroupingText="Successful Payment" Height="330px" HorizontalAlign="Center" Width="857px" ForeColor="#539165" CssClass="auto-style2">
                &nbsp;<br />
                
                <br />
                <asp:Label runat="server" Text="Payment Completed Successfully" Font-Bold="True" ForeColor="#539165" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <asp:Button ID="back_to_homepage" runat="server" Text="Go Back to Homepage" Width="250px" Height="34px" ForeColor="#FFFFFF" BackColor="#539165" OnClick="back_to_homepage_Click"></asp:Button>
                
        </asp:Panel>
        </div>
    </form>
</body>


</html>
