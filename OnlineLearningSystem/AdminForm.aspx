<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminForm.aspx.cs" Inherits="OnlineLearningSystem.AdminForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
    <style type="text/css">
        .auto-style1 {
            height: 690px;
        }
        .auto-style2 {
            margin-left: 25px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
&nbsp;&nbsp;&nbsp;
            
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Admin Dashboard"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Ahmed Mohamed"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            
        <asp:GridView ID="course_grid" AutoGenerateColumns="False" runat="server" CellPadding="6"  
            ForeColor="#333333" BorderStyle="Double" HorizontalAlign="Center" BorderWidth="5px" GridLines="Vertical" Height="16px" Width="1450px" OnSelectedIndexChanged="course_grid_SelectedIndexChanged1" EnableViewState="False" OnRowDeleted="course_grid_RowDeleted" OnRowDeleting="course_grid_RowDeleting" >  
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
                <asp:BoundField DataField="CourseID" HeaderText="Course ID" />  
                <asp:BoundField DataField="Name" HeaderText="Name" />  
                <asp:BoundField DataField="Professor" HeaderText="Professor" />  
                <asp:BoundField DataField="Description" HeaderText="Description" />  
                <asp:BoundField DataField="Price" HeaderText="Price L.E" />  
                <asp:BoundField DataField="Duration" HeaderText="Duration" />  
                <asp:BoundField DataField="Rating" HeaderText="Rating" />
                
                <asp:CommandField ShowSelectButton="True" SelectText="Select" />
                <asp:CommandField ShowDeleteButton="True" />

            </Columns>  
        </asp:GridView> 
            <br />
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" GroupingText="Data Access" Height="272px" Width="1454px">
                <asp:Label ID="id_lbl" runat="server" Text="ID" Width="120px"></asp:Label>
                <asp:TextBox ID="id_txt" runat="server" Enabled="False" Width="221px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="id_lbl3" runat="server" Text="Price" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_price" runat="server" Width="221px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_add" runat="server" Height="34px" Text="Add" Width="148px" OnClick="btn_add_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <asp:Label ID="id_lbl0" runat="server" Text="Name" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_name" runat="server" Width="221px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="id_lbl4" runat="server" Text="Duration" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_duration" runat="server" Width="221px"></asp:TextBox>
                &nbsp;<br />
                <asp:Label ID="id_lbl1" runat="server" Text="Professor" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_prof" runat="server" Width="221px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="id_lbl5" runat="server" Text="Rating" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_rating" runat="server" TextMode="Number" Width="219px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_edit" runat="server" Height="34px" OnClick="btn_edit_Click" Text="Edit" Width="148px" />
                &nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="id_lbl2" runat="server" Text="Description" Width="120px"></asp:Label>
                <asp:TextBox ID="txt_desc" runat="server" Height="73px" TextMode="MultiLine" Width="221px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="error_lbl" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Please fill your fields and max rating is 5" Visible="False"></asp:Label>
            </asp:Panel>

            <asp:Button ID="Logout" runat="server" Height="34px" Text="Logout" Width="148px" OnClick="Logout_Click" />
            </div>
    </form>
</body>
</html>
