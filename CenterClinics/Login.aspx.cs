using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CenterClinics
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /* protected void Button_Login(object sender, EventArgs e)
         {
             string email = InputEmail.Text;
             string password = InputPassword.Text;
             ConnectionToTheData connection = new ConnectionToTheData();
             DataTable user = connection.checkUser(email, password);

             if (user != null && user.Rows.Count > 0)
             {
                 LoginState.Text = "Login successful!";
                 LoginState.CssClass = "success-label";
             }
             else
             {
                 LoginState.Text = "Invalid credentials. Please try again.";
                 LoginState.CssClass = "error-label";
             }
         }*/
        protected void Button_Login(object sender, EventArgs e)
        {
            string email = InputEmail.Text;
            string password = InputPassword.Text;

            ConnectionToTheData connection = new ConnectionToTheData();
            DataTable user = connection.checkUser(email, password);


            if (user.Rows.Count > 0)
            {
                string role = user.Rows[0]["UserType"].ToString();

                Session["Email"] = email;
                Session["Password"] = password;

                LoginState.Text = "Login successful!";
                LoginState.CssClass = "success-label";

                switch (role)
                {
                    case "Patient":
                        Response.Redirect("PatientPage.aspx");
                        break;
                    case "Doctor":
                        Response.Redirect("DoctorPage.aspx");
                        break;
                    case "Admin":
                        Response.Redirect("Admin.aspx");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                LoginState.Text = "Invalid credentials. Please try again.";
                LoginState.CssClass = "error-label";
            }

        }

    }
}