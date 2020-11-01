<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expertkn.aspx.cs" Inherits="DB15.Expertkn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 22px;
            width: 220px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-orientation="horizontal" style="font-family: 微軟正黑體; font-style: normal; font-size: 30px; color: #FF5050">
            新增知識
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="27px" OnTextChanged="TextBox1_TextChanged" Width="249px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Height="36px" Text="送出" Width="81px" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" Height="36px" Width="81px" runat="server" Text="回到專家頁" OnClick="Button2_Click" />
    </form>
</body>
</html>
