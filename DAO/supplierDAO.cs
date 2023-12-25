using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class supplierDAO
    {
        Database db;
        public supplierDAO()
        {
            db = new Database();
        }
        public DataTable LayDSNhaCC()
        {
            string strSQL = "Select * From Supplier s";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaNCCMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(SupplierID, 4, LEN(SupplierID) - 3) AS INT)) AS MaxSupplierNumber FROM Supplier";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        ma = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ma;
        }
        public bool ThemNhaCC(supplierDTO sup)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Supplier (SupplierID,NameSupplier,Address,Phone,ContactPerson ) VALUES (@SupplierID,@SupplierName,@Address,@Phone,@Contact)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", sup.getSuppID());
                        command.Parameters.AddWithValue("@SupplierName", sup.getSuppName());
                        command.Parameters.AddWithValue("@Address", sup.getAddress());
                        command.Parameters.AddWithValue("@Phone", sup.getPhone());
                        command.Parameters.AddWithValue("@Contact", sup.getContactPerson());

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected == 1;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool XoaNhaCC(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatNhaCC(supplierDTO sup)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Supplier SET NameSupplier=@SupplierName,Address=@Address,Phone=@Phone,ContactPerson=@ContactPerson WHERE SupplierID = @SupplierID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@SupplierName", sup.getSuppName());
                    command.Parameters.AddWithValue("@Address", sup.getAddress());
                    command.Parameters.AddWithValue("@Phone", sup.getPhone());
                    command.Parameters.AddWithValue("@ContactPerson", sup.getContactPerson());
                    command.Parameters.AddWithValue("@SupplierID", sup.getSuppID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public List<supplierDTO> SearchSupplierByID(string data)
        {
            List<supplierDTO> list = new List<supplierDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT SupplierID,NameSupplier,Address,Phone,ContactPerson FROM Supplier WHERE SupplierID=@SupplierID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@SupplierID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            supplierDTO cus = new supplierDTO(
                                sdr["SupplierID"].ToString(),
                                sdr["NameSupplier"].ToString(),
                                sdr["Address"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["ContactPerson"].ToString());

                            list.Add(cus);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return list;
        }
        public List<supplierDTO> SearchSupplierByName(string data)
        {
            List<supplierDTO> list = new List<supplierDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT SupplierID,NameSupplier,Address,Phone,ContactPerson FROM Supplier WHERE NameSupplier like '%" + data + "%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            supplierDTO cus = new supplierDTO(
                                   sdr["SupplierID"].ToString(),
                                   sdr["NameSupplier"].ToString(),
                                   sdr["Address"].ToString(),
                                   sdr["Phone"].ToString(),
                                   sdr["ContactPerson"].ToString());


                            list.Add(cus);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return list;
        }
    }
}

