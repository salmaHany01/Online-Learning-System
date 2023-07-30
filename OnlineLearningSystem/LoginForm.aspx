<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="OnlineLearningSystem.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Online Learning</title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 259px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<br />
            <br />
            <br />
            <asp:Panel ID="Panel1"  runat="server" EnableTheming="True" GroupingText="Login Form" Height="330px" HorizontalAlign="Center" Width="857px" CssClass="auto-style2">
                &nbsp;<br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Email" Width="150px"></asp:Label>
                <asp:TextBox ID="txt_emailL" runat="server" TextMode="Email" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Password" Width="150px"></asp:Label>
                <asp:TextBox ID="txt_passL" runat="server" TextMode="Password" Width="215px"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_signin" runat="server" CausesValidation="False" Height="50px" OnClick="btn_signup_Click" Text="Sign In" Width="200px" />
                <br />
                <asp:Label runat="server" Text="Don't have an account yet?"></asp:Label>
                <asp:HyperLink runat="server" NavigateUrl="~/RegisterForm.aspx">Register Now</asp:HyperLink>
                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="error_lbl" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Please fill your fields and max rating is 5" Visible="False"></asp:Label>
            </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
         
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
