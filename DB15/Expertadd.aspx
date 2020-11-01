<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expertadd.aspx.cs" Inherits="DB15.Expertadd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 336px;
        }
        #Text2 {
            height: 17px;
            width: 170px;
        }
        #Text8 {
            height: 24px;
            width: 601px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-orientation="horizontal" style="font-family: 微軟正黑體; font-style: normal; font-size: 30px; color: #FF5050">
        新增筆電資料</div>
        <p>
    筆電類型&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:DropDownList ID="DropDownList1" runat="server" Height="50px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="110px">
            <asp:ListItem>----請選擇----</asp:ListItem>
            <asp:ListItem>文書筆電</asp:ListItem>
            <asp:ListItem>電競筆電</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        型號&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox1" runat="server" Width="422px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            
        <br />
        <br />
        處理器&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox2" runat="server" Width="202px"></asp:TextBox>
            <br />
        <br />
        <br />
        RAM&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="175px"></asp:TextBox>
            <br />
        <br />
        硬碟大小&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
        <br />
        <br />
        顯示卡規格&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
        <br />
        <br />
        螢幕大小&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
        <br />
        <br />
        價格&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
            <br />
        <br />
        <br />
        購買網址&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox8" runat="server" Height="20px" Width="686px"></asp:TextBox>
        </p>
        <p>
            &nbsp;<br />
            <asp:Button ID="Button1" runat="server" Text="新增" Width="81px" Height="27px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            </p>
    </form>
    </body>
</html>
