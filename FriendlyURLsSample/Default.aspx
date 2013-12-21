﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FriendlyURLsSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Greeting!</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      Enter your name:
      <asp:TextBox ID="Name" runat="server"></asp:TextBox>
      <asp:Button ID="Greet" runat="server" Text="Greet" OnClick="Greet_Click" />
    </div>
  </form>
</body>
</html>
