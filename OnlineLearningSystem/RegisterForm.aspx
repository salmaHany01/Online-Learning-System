<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="OnlineLearningSystem.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <style type="text/css">
        .auto-style1 {
            height: 613px;
        }
        .auto-style2 {
            margin-left: 259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;
            <asp:Panel ID="Panel1"  runat="server" EnableTheming="True" GroupingText="Register Form" Height="330px" HorizontalAlign="Center" Width="857px" CssClass="auto-style2">
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="User Name" Width="150px"></asp:Label>
                &nbsp;<asp:TextBox ID="txt_usernameR" runat="server" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Email" Width="150px"></asp:Label>
                <asp:TextBox ID="txt_emailR" runat="server" TextMode="Email" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Password" Width="150px"></asp:Label>
                <asp:TextBox ID="txt_passR" runat="server" TextMode="Password" Width="215px"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_signup" runat="server" CausesValidation="False" Height="50px" OnClick="btn_signup_Click" Text="SignUp" Width="200px" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="error_lbl" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Please fill your fields and max rating is 5" Visible="False"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
