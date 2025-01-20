using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CenterClinics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectionToTheData connection = new ConnectionToTheData();

            DataTable dt = connection.GetDoctors();
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ConnectionToTheData connection = new ConnectionToTheData();

            DataTable dtt = connection.GetPatients();
            GridView2.DataSource = dtt;
            GridView2.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            ConnectionToTheData connection = new ConnectionToTheData();

            DataTable dtt = connection.GetClinics();
            GridView3.DataSource = dtt;
            GridView3.DataBind();
        }
        protected void btnAddClinic_Click(object sender, EventArgs e)
        {
            string name = txtClinicName.Text;
            string open = txtOpenTime.Text;
            string close = txtCloseTime.Text;
            int specialtyID;
            if (int.TryParse(txtSpecialtyID.Text, out specialtyID))
            {
                ConnectionToTheData connection = new ConnectionToTheData();
                bool success = connection.AddClinic(name, open, close, specialtyID);
                if (success)
                { // تظهر رسالة النجاح
                    Response.Write("تم إضافة العيادة بنجاح.");
                }
                else { // تظهر رسالة الخطأ
                    Response.Write("حدث خطأ أثناء الإضافة.");
                }
            }
            else
            {
                Response.Write("يرجى إدخال رقم صحيح لمعرف التخصص.");
            }
        }
    }  
    
       
}


