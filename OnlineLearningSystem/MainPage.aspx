<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="OnlineLearningSystem.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Learning</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="time_display" runat="server" Text="Label" Font-Size="32px" ForeColor="#ACBCFF"></asp:Label>

        <asp:GridView ID="grid_view" runat="server" CellPadding="6" ForeColor="#333333" BorderStyle="Double" HorizontalAlign="Center" BorderWidth="5px" GridLines="Vertical" Height="16px" Width="1450px" AutoGenerateColumns="False" OnSelectedIndexChanged="grid_view_SelectedIndexChanged" AutoGenerateSelectButton="True">
            <AlternatingRowStyle BackColor="White" />  
            <EditRowStyle BackColor="#7C6F57" />  
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />  
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />  
            <RowStyle BackColor="#E3EAEB" />  
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />  
            <SortedAscendingCellStyle BackColor="#F8FAFA" />  
            <SortedAscendingHeaderStyle BackColor="#246B61" />  
            <SortedDescendingCellStyle BackColor="#D4DFE1" />  
            <SortedDescendingHeaderStyle BackColor="#15524A" />  
                <Columns>
                    <asp:BoundField DataField="courseID" HeaderText="id" />
                    <asp:BoundField DataField="name" HeaderText="name" />
                    <asp:BoundField DataField="professor" HeaderText="prof" />
                    <asp:BoundField DataField="description" HeaderText="desc" />
                    <asp:BoundField DataField="price" HeaderText="price" />
                    <asp:BoundField DataField="duration" HeaderText="duration" />
                    <asp:BoundField DataField="rating" HeaderText="rating" />
                </Columns>
            </asp:GridView>
         <br />
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="add_to_cart_Click" Width="148px" Height="34px" Text="Add to cart" />
            <asp:Button ID="Button2" runat="server" OnClick="view_cart_Click" Width="148px" Height="34px" Text="View cart" />
            <asp:Label ID="error_lbl" runat="server" Font-Bold="True" ForeColor="#000000" Text="error" Visible="False"></asp:Label>
        </div>

        <br />
        <asp:Button ID="logofut" runat="server" Text="Logout" Width="148px" Height="34px" BackColor="#E76161" OnClick="logofut_Click" />
        
    </form>
</body>
</html>
