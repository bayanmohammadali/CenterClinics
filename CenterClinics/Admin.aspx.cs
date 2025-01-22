using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CenterClinics
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                LoadSpecialtiesToDropDownList();
            }
        }
        private void LoadSpecialtiesToDropDownList()
        {
            ConnectionToTheData connection = new ConnectionToTheData();
            DataTable dtt = connection.GetSpecialties();
            DropDownList1.DataSource = dtt;
            DropDownList1.DataValueField = "SpecialtyID";
            DropDownList1.DataTextField = "SpecialtyName"; 
            DropDownList1.DataBind();

            DropDownList1.Items.Insert(0, new ListItem("Chooes Specialties ", "")); 
            
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectionToTheData connection = new ConnectionToTheData();

            DataTable dt = connection.GetDoctors();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button1_add_Clinic(object sender, EventArgs e)
        {
            ConnectionToTheData connection = new ConnectionToTheData();

            string clinicName = ClinicName.Text;
            string openTime = OpenTime.Text;
            string closeTime = CloseTime.Text; 
            int specialtyId = int.Parse(DropDownList1.SelectedValue);
            bool dt = connection.AddClinic(clinicName, openTime, closeTime, specialtyId);
            if (dt == true )
            {
                AddState.Text = "Add Clinic successful!";
               
            }
            else
            {
                AddState.Text = "failed ";
            }
            
        }
    }
}