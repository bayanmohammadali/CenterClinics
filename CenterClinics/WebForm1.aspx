<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CenterClinics.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="All Doctors" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="All Patint" OnClick="Button2_Click" />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
         <div>
            <asp:Button ID="Button3" runat="server" Text="All Clinics" OnClick="Button3_Click" />
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="اسم العيادة:">

            </asp:Label> <asp:TextBox ID="txtClinicName" runat="server">

            </asp:TextBox><br /> <asp:Label ID="Label2" runat="server" Text="وقت الفتح:">

      </asp:Label> <asp:TextBox ID="txtOpenTime" runat="server">

       </asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="وقت الإغلاق:">

            </asp:Label> <asp:TextBox ID="txtCloseTime" runat="server">

           </asp:TextBox><br /> <asp:Label ID="Label4" runat="server" Text="تخصص العيادة:">

           </asp:Label> <asp:TextBox ID="txtSpecialtyID" runat="server">

           </asp:TextBox><br /> <asp:Button ID="btnAddClinic" runat="server" Text="إضافة" OnClick="btnAddClinic_Click" />
        </div>
    </form>
</body>
</html>
