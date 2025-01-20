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
        string connectionString = @"data source=BAYAN-MOHAMMAD-\SQLEXPRESS;Database=ClinicDB;Integrated Security=True";
        string sql = null;
        SqlConnection connection = null;
        SqlCommand command;

        public DataTable checkUser(string firstName, string passwordHash)
        {
            string sql = @"SELECT u.UserID, u.UserType, u.FirstName, u.LastName, u.Gender, u.Email, u.Password, u.Phone_Number, u.Address 
                  FROM Users u 
                  WHERE u.FirstName = @firstName AND u.Password = @passwordHash";
            var dt = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@passwordHash", passwordHash);
                var dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }

            return dt;
        }


        public DataTable GetDoctors()
        {

            DataTable dataTable = new DataTable();

            using (connection = new SqlConnection(connectionString))
            {
                sql = "SELECT * from Doctors";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
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

            using (connection = new SqlConnection(connectionString))
            {
                sql = "SELECT * from patients";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public DataTable GetClinics()
        {
            DataTable dataTable = new DataTable();

            using (connection = new SqlConnection(connectionString))
            {
                sql = "SELECT * from Clinics";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public bool AddClinic(string clinicName, string openTime, string closeTime, int specialtyID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clinics (ClinicName, OpenTime, CloseTime, SpecialtyID) VALUES (@ClinicName, @OpenTime, @CloseTime, @SpecialtyID)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClinicName", clinicName);
                    cmd.Parameters.AddWithValue("@OpenTime", openTime);
                    cmd.Parameters.AddWithValue("@CloseTime", closeTime);
                    cmd.Parameters.AddWithValue("@SpecialtyID", specialtyID);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    { // التعامل مع الخطأ (يمكنك تسجيل الخطأ إذا لزم الأمر)
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

        }
    }

}
