<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="Alert" Text="测试Alert" onclick="Alert_Click" CausesValidation="False" />
        <asp:Button runat="server" ID="Respose" Text="测试输出js" onclick="Respose_Click" CausesValidation="False" />
        <asp:Button runat="server" ID="LoginOut" Text="退出测试"  onclick="LoginOut_Click" CausesValidation="False"  />
        <asp:Button runat="server" ID="Refresh" Text="刷新当前页" onclick="Refresh_Click" CausesValidation="False"   />
    </div>
    </form>
</body>
</html>
