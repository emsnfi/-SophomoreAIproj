<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="首頁.aspx.cs" Inherits="DB15.首頁" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style type="text/css">
        #Text1 {
            height: 17px;
            width: 167px;
        }
    </style>

    <center>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    
        <body>
            <form id="form1" runat="server" style="font-family: '微軟正黑體 Light'">
        <div aria-orientation="horizontal" style="font-family: 微軟正黑體; font-style: normal; font-size: 30px; color: #FF5050">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="http://www.clipartbest.com/cliparts/xig/ajM/xigajMriA.jpeg" width="55px"/> Welcome~~&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1"  Height="32px" Text="我是專家" Width="102px" runat="server" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;</div>
               
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 正在為選擇筆電感到心煩嗎? 我們可以幫助你&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label1" runat="server" visible ="false" Text="請輸入密碼"></asp:Label>
&nbsp;<input id="Text1" runat="server" visible ="false" type="text" />&nbsp;
                <asp:Button ID="Button2" runat="server" visible ="false" Text="確認" Width="67px" OnClick="Button2_Click" />
                <p style="margin-left: 100px">
            <asp:ImageButton ID="ImageButton1" src="https://fcit.usf.edu/matrix/wp-content/uploads/2017/01/DanceBot-3-LG.gif" runat="server" Height="65px" Width="76px" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" src="https://www.weya.com.tw/uploads/design/design_20160706155541.gif" runat="server" Height="65px" Width="76px" OnClick="ImageButton2_Click" />
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;按此進入聊天模式&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 按此進入網頁模式<br />
    </form>
</body>
    </center>
    
</html>
