<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="DB15.Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div aria-orientation="horizontal" style="font-family: 微軟正黑體; font-style: normal; font-size: 30px; color: #0026ff">
            <asp:Button ID="Button1" runat="server" Height="49px" Text="首頁" Width="114px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Height="49px" Text="跟機器人聊聊" Width="114px" OnClick="Button2_Click" />
            &nbsp;
            <asp:Image ID="Image1" src = "http://www.doctorlaptop-repair-jack.com/Cartoon%20Laptop.JPG" runat="server" Height="101px" Width="146px" />
            &nbsp;筆電聖地&nbsp;<asp:Image ID="Image2" src = "https://face.zhaoxi.org/upload/qq/ZJBQ/20111/201101250126301331.gif" runat="server" Height="101px" Width="146px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
         
        <br />
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
        <asp:Label ID="Label1" runat="server" Text="筆電類型"></asp:Label>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="價格區間"></asp:Label>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="螢幕大小"></asp:Label>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 品牌&nbsp;&nbsp;
        <br />
        &nbsp;
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" Height="38px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" Width="127px" AutoPostBack="True">
            <asp:ListItem>------請選擇------</asp:ListItem>
            <asp:ListItem>文書筆電</asp:ListItem>
            <asp:ListItem>電競筆電</asp:ListItem>
        </asp:DropDownList>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>------請選擇------</asp:ListItem>
            <asp:ListItem>10000元以下</asp:ListItem>
            <asp:ListItem>10000元~20000元</asp:ListItem>
            <asp:ListItem>20000元以上</asp:ListItem>
        </asp:DropDownList>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>------請選擇------</asp:ListItem>
            <asp:ListItem>11吋~14吋(含)</asp:ListItem>
            <asp:ListItem>15吋(含)以上</asp:ListItem>
        </asp:DropDownList>
         
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" Height="16px" style="margin-bottom: 0px" Width="113px">
            <asp:ListItem>------請選擇------</asp:ListItem>
            <asp:ListItem>ASUS</asp:ListItem>
            <asp:ListItem>ACER</asp:ListItem>
            <asp:ListItem>DELL</asp:ListItem>
            <asp:ListItem>MSI</asp:ListItem>
            <asp:ListItem>GIGABYTE</asp:ListItem>
            <asp:ListItem>Lenovo</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="29px" Text="聽聽專家的說法" Width="132px" OnClick="Button3_Click" />
         <br />
        <br />
         <asp:Image ID="Image3" src ="https://static.wixstatic.com/media/c57da0_4efc2367d9984625aa6d60a485df0a3b~mv2.png_256" visible = "false" runat="server" Height="92px" Width="97px" />
        <asp:Label ID="Label4"  runat="server" visible = "False" Text="Label" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
       <div>
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
          
           </div>
        


        &nbsp;&nbsp;&nbsp;
        <div style="margin-left: 640px">
            
        </div>



        <br />
         
        </form>
</body>
</html>
