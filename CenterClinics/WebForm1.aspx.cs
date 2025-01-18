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
            GetDoctorsAndFillTable();
        }

        private void GetDoctorsAndFillTable()
        {
            try
            {
                ConnectionToTheData connectionToData = new ConnectionToTheData();
                DataTable dataTable = connectionToData.GetDoctors();
                Table1.Rows.Clear(); // لتنظيف الجدول من أي صفوف سابقة

                // إضافة الأعمدة (رؤوس الجدول)
                TableHeaderRow headerRow = new TableHeaderRow();
                foreach (DataColumn column in dataTable.Columns)
                {
                    TableHeaderCell headerCell = new TableHeaderCell();
                    headerCell.Text = column.ColumnName;
                    headerRow.Cells.Add(headerCell);
                }
                Table1.Rows.Add(headerRow);

                // إضافة الصفوف (بيانات الجدول)
                foreach (DataRow row in dataTable.Rows)
                {
                    TableRow tableRow = new TableRow();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        TableCell tableCell = new TableCell();
                        tableCell.Text = row[column].ToString();
                        tableRow.Cells.Add(tableCell);
                    }
                    Table1.Rows.Add(tableRow);
                }
            }
            catch (Exception ex)
            {
                // التعامل مع الاستثناء هنا
                // يمكنك عرض رسالة خطأ أو تسجيل الاستثناء
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}


