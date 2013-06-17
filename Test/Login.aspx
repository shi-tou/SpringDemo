<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Test.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
    <link href="theme/css/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="topnav">
        <ul>
            <li><a href="Default.aspx">首页</a></li>
            <li><a href="#">首页</a></li>
            <li><a href="#">首页</a></li>
            <li><a href="#">首页</a></li>
            <li><a href="#">首页</a></li>
            <li><a href="#">首页</a></li>
        </ul>
    </div>
    <div class="login">
        <div id="title">用户登录</div><br /><br />
        <table>
            <tr>
                <td class="w120 tar">用户帐号：</td>
                <td><asp:TextBox ID="txtUserName" runat="server" class="w180"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tar">用户密码：</td>
                <td><asp:TextBox ID="txtPassWord" runat="server" class="w180"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" class="btn" Text="登录" onclick="btnLogin_Click"/>&nbsp;
                    <asp:Button ID="btnCancel" runat="server" class="btn1" Text="取消" OnClientClick="return false;"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
