<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greeting.aspx.cs" Inherits="FriendlyURLsSample.Greeting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Greeting!</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      Hello! <%: Name %>
    </div>
  </form>
</body>
</html>
