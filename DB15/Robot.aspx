<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Robot.aspx.cs" Inherits="DB15.Robot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 300px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" src ="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" width = "50px" length="50px" />

           
            <asp:Label ID="Label2" runat="server" Text="Hello, 請問想要什麼類型的筆電呢 ?" Font-Size="Larger"></asp:Label>

           
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Height="40px" Text="電競筆電" Width="102px" OnClick="Button1_Click" BackColor="#FFFFCC" BorderColor="White" Font-Size="Large"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="40px" Text="文書筆電" Width="102px" OnClick="Button2_Click" BackColor="#FFFFCC" Font-Size="Large" />
            <br />
            <br />

            <div id ="select2" runat="server"  style="margin-left: 1px" visible="False">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" src ="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" width = "50px" length="50px" />

            <asp:Label ID="Label3" runat="server" Text="您的預算大概是多少呢?" Font-Size="Larger"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="2萬~3萬" Width="102px" OnClick="Button4_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="3萬~4萬" Width="102px" OnClick="Button5_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="5萬以上" Width="102px" OnClick="Button6_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="都可以" Width="102px" OnClick="Button7_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <br />
                <br />
                </div>
            <div id ="select3" runat="server"  style="margin-left: 1px" visible="False">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image3" runat="server" src ="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" width = "50px" length="50px" />

            <asp:Label ID="Label6" runat="server" Text="您想要什麼品牌呢?" Font-Size="Larger"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="ACER" Width="102px" OnClick="Button8_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="ASUS" Width="102px" OnClick="Button9_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="Lenova" Width="102px" OnClick="Button10_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button11" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="Dell" Width="102px" OnClick="Button11_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button12" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="MSI" Width="102px" OnClick="Button12_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button13" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="GIGABYTE" Width="102px" OnClick="Button13_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button14" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="都可以" Width="102px" OnClick="Button14_Click" />
                <br />
                <br />

           </div>
                <div id ="select4" runat="server"  style="margin-left: 1px" visible="False">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image4" runat="server" src ="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" width = "50px" length="50px" />
                
            <asp:Label ID="Label7" runat="server" Text="您想要什麼處理器呢?" Font-Size="Larger"></asp:Label>
            
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button15" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="i5" Width="102px" OnClick="Button15_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button16" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="i7" Width="102px" OnClick="Button16_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button17" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="都可以" Width="102px" OnClick="Button17_Click" />
&nbsp;
                <br />
                <br />

            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
                    </div>
            <div id ="select5" runat="server"  style="margin-left: 1px" visible="False">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image5" runat="server" src ="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" width = "50px" length="50px" />

            <asp:Label ID="Label8" runat="server" Text="您想要什麼大小呢?" Font-Size="Larger"></asp:Label>
            
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button18" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="15.6" Width="102px" OnClick="Button18_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button19" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="17.3" Width="102px" OnClick="Button19_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button20" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="都可以" Width="102px" OnClick="Button20_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button21" runat="server" BackColor="#FFFFCC" Font-Size="Large" Height="40px" Text="都可以" Width="102px" OnClick="Button21_Click" />
            
           
                <br />
            </div>
           
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Font-Names="標楷體" Font-Size="Larger" ForeColor="#CC0000" Text="沒有符合您需求的筆電嗎，請按重新選擇" Visible="False"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button22" runat="server" BackColor="#99FF99" Text="重新選擇" OnClick="Button22_Click" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button24" runat="server" BackColor="#99FF99" Text="聽聽專家說法" OnClick="Button24_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button23" runat="server" BackColor="#99FF99" Text="回首頁" OnClick="Button23_Click" />
            <br />
           
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Image ID="Image6" src ="https://static.wixstatic.com/media/c57da0_4efc2367d9984625aa6d60a485df0a3b~mv2.png_256" visible = "false" runat="server" Height="73px" Width="97px" />
        <asp:Label ID="Label4"  runat="server" visible = "False" Text="Label" Font-Size="XX-Large"></asp:Label>           
           
            <br />
           
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False" style="margin-left: 60px" Width="448px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            
           
            
            </div>

          

        </form>
    </body>
    </html>
