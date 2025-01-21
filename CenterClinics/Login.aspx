<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CenterClinics.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Login" runat="server">
        <div>
            <h3>Enter Your Email:</h3>
            <asp:TextBox ID="InputEmail" runat="server" CssClass="text-input" />    
            <h3>Password:</h3>

          <asp:TextBox ID="InputPassword" TextMode="Password" runat="server" CssClass="text-input" />

            <asp:Button CssClass="btnLog" ID="btnLogin" runat="server" Text="Login" OnClick="Button_Login"/><br /><br />

            <asp:Label ID="LoginState" style="color:red" runat="server" Text="" Font-Italic="True"></asp:Label><br /><br />

            <pre>Don't Have an Account ? <a href="signUp.aspx">Create One.</a></pre>
        </div>
        
    </form>
</body>
</html>
