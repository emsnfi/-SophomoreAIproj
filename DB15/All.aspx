<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="DB15.All" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-orientation="horizontal" style="font-family: 微軟正黑體; font-style: normal; font-size: 30px; color: #FF5050" runat="server">
        所有筆電
        </div>

        <p>
         <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  style="margin-top: 4px" Width="608px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
               
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle  BackColor="#6F8DAE" />          
            </asp:GridView>
        </p>
        
            <asp:Button ID="Button1" runat="server" Height="49px" Text="cjo62" Width="114px" OnClick="Button1_Click" />
    </form>
</body>
    
</html>
