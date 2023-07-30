<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="OnlineLearningSystem.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="cart_grid" runat="server" CellPadding="6" ForeColor="#333333" BorderStyle="Double" HorizontalAlign="Center" BorderWidth="5px" GridLines="Vertical" Height="16px" Width="1450px"  AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="cart_grid_SelectedIndexChanged">
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
                    <asp:BoundField DataField="courseID" HeaderText="Course id" />
                    <asp:BoundField DataField="name" HeaderText="name" />
                    <asp:BoundField DataField="price" HeaderText="price" />
                    
                </Columns>
            </asp:GridView>
            <asp:Label ID="total_price" runat="server" Text="Label" Font-Size="32px" ForeColor="#ACBCFF"></asp:Label>
            
        </div>
        <div>
            <asp:Button ID="delete_item_btn" runat="server" Text="Delete" Width="148px" Height="34px" OnClick="delete_item_btn_Click"></asp:Button>
            <asp:Button ID="proceed_btn" runat="server" Text="Proceed to Payment" Width="148px" Height="34px" OnClick="proceed_btn_Click" />
        </div>
    </form>
</body>
</html>
