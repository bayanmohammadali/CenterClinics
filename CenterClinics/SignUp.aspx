<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CenterClinics.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        body
        {
            font-family: Arial, sans-serif; 
            background-color: #f4f4f9;
            display: flex;
            justify-content: center; 
            align-items: center;
         

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1 style="color:#CC0000; font-style: italic; text-decoration: underline;" >SignUp</h1>
            <hr />
            <h3>UserType: </h3>
             <asp:DropDownList ID="ddlUserType" runat="server"> 
                 <asp:ListItem Text="Choose the type of account" Value="" />
                 <asp:ListItem Text="Patient" Value="Patient" /> 
                 <asp:ListItem Text="Doctor" Value="Doctor" />
                 <asp:ListItem Text="Admin" Value="Admin" />
             </asp:DropDownList>
            <h3> FirstName:</h3>
            <input id="InputFirstName" type="text" runat="server" style="border-style: double; border-color: #CC0000;" required="required"/><br />
            <h3>LastName: </h3>
            <input id="InputLastName" type="text" runat="server" style="border-style: double; border-color: #CC0000;" required="required"/><br />
            <h3> Gender:</h3>
             <input id="GenderMale" type="radio" name="Gender" value="M" runat="server"/> Male
            <input id="GenderFemale" type="radio" name="Gender" value="F" runat="server"/> Female
            <h3>Email:</h3>
            <input id="InputEmail" type="text" style="border-style: double; border-color: #CC0000; />
            <h3> Password:</h3>
            <input id="InputPassword" type="password"  style="border-style: double; border-color: #CC0000; />
            <h3> Phone_Number:</h3>
            <input id="InputPhone" type="text" style="border-style: double; border-color: #CC0000;" />
            <h3>Address:</h3>
            <input id="InputAddress" type="text"  style="border-style: double; border-color: #CC0000;" />
        </div>
    </form>
</body>
</html>
