using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CenterClinics
{
    public class ConnectionToTheData
    {
         string conntionString = @"data source= BAYAN-MOHAMMAD-\SQLEXPRESS;database=ClinicDB;integrated securaity=SSPI";
        string sql = null;
        SqlConnection connection = null;
        SqlCommand command;

            public DataTable checkUser(string firstName, string password)
            {
                DataTable dt = new DataTable();
                string query = "SELECT u.UserID, u.UserType, u.FirstName, u.LastName, u.Gender, u.Email, u.Password, u.Phone_Number, u.Address FROM Users u WHERE u.FirstName = @firstName AND u.Password = @passwordHash";

            using (connection = new SqlConnection(conntionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@passwordHash", password.GetHashCode());

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dt);
                    }
                }

                return dt;
            }
        

        public DataTable GetDoctors()
        {

            DataTable dataTable = new DataTable();
            
            using ( connection = new SqlConnection(conntionString))
            {
                sql = "SELECT * from Doctors";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection)) 
                { connection.Open(); 
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand)) 
                    { 
                        sqlDataAdapter.Fill(dataTable); 
                    }
                }
            }
            return dataTable;
        }

        public DataTable GetPatients()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * from Patints";
            using ( connection = new SqlConnection(conntionString))
            {
              command = new SqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("An error .", ex);
                }
            }
        }


    }
}
