<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="CenterClinics.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin pags:</title>
    <style> 
         body
        {
            font-family: Arial, sans-serif; 
            background-color: #f4f4f9;
            display: flex;
            justify-content: left; 
            align-items: flex-start;
            height: 100vh; 
            margin: 0;

        }

    </style>
</head>
<body>
  
    <form id="form1" runat="server">
        <div>
            <h3>Admin page:</h3>
          <div>
            <asp:Label ID="Label1" runat="server" Text="view Clinics"></asp:Label>
           <asp:Button ID="Button3" runat="server" Text="All Clinics" OnClick="Button3_Click" />
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="true"></asp:GridView>
          </div>
           <br /> <hr />
            <div>
            <asp:Label ID="Label2" runat="server" Text="view Doctors"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="All Doctors" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
             <br /> <hr />
        <div>
           <asp:Label ID="Label3" runat="server" Text="view Patints"></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="All Patint" OnClick="Button2_Click" />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
         <br /> <hr />
            

            </div>
        <from >
            <h3> Add Clinic:</h3>
                <div class="form-group">
                    <label for="ClinicName"> ClinicName :</label> 
                    
                    <asp:TextBox ID="ClinicName" runat="server" />

                </div>
             <br /><br />

            <div class="form-group">
                    <label for="OpenTime">OpenTime :</label>
                    <asp:TextBox ID="OpenTime" runat="server" />
                       </div> 
             <br /><br />
            <div class="form-group"> 
                           <label for="CloseTime">CloseTime:</label>
                          <asp:TextBox ID="CloseTime" runat="server" />

            </div>
             <br /><br />
                <div class="form-group"> 
                    <label for="SpecialtyID"> SpecialtyID </label> 
                    <asp:DropDownList ID="DropDownList1" runat="server">
                     
                      <asp:ListItem Text="Choose the type of Specialty" Value="" />
            
                    </asp:DropDownList>
                    <br /> <br />
                </div>
            <asp:Button ID="Button4" runat="server" Text="Add Clinic" OnClick ="Button1_add_Clinic" />

            <asp:Label ID="AddState" runat="server" Text="" />
            </from>
       <br /> <hr />

         
            </form>
</body>
</html>
