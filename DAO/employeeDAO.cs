using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class employeeDAO
    {
        Database db;
        public employeeDAO()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select * From Employee e";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayMaNhanVien()
        {
            string strSQL = "Select EmpID From Employee e";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaNVMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(EmpID, 3, LEN(EmpID) - 2) AS INT)) AS MaxEmpNumber FROM Employee";

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
        public bool ThemNhanVien(employeeDTO emp)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Employee (EmpID,EmpName,Position,Phone, Address ) VALUES (@EmpID,@EmpName,@Position,@Phone,@Address)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", emp.getEmpID());
                        command.Parameters.AddWithValue("@EmpName", emp.getEmpName());
                        command.Parameters.AddWithValue("@Position", emp.getPosition());
                        command.Parameters.AddWithValue("@Phone", emp.getPhone());
                        command.Parameters.AddWithValue("@Address", emp.getAddress());

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
        public bool XoaNhanVien(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Employee WHERE EmpID = @EmpID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message );
                return false;
            }
           
        }
        public bool CapNhatNV(employeeDTO emp)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Employee SET EmpName=@EmpName,Position=@Position,Phone=@Phone,Address=@Address WHERE EmpID = @EmpID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmpName", emp.getEmpName());
                    command.Parameters.AddWithValue("@Position", emp.getPosition());
                    command.Parameters.AddWithValue("@Phone", emp.getPhone());
                    command.Parameters.AddWithValue("@Address", emp.getAddress());
                    command.Parameters.AddWithValue("@EmpID", emp.getEmpID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public List<employeeDTO> SearchEmployeeByID(string data)
        {
            List<employeeDTO> list = new List<employeeDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT EmpID,EmpName,Position, Phone, Address FROM Employee WHERE EmpID=@EmpID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@EmpID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            employeeDTO cus = new employeeDTO(
                                sdr["EmpIDID"].ToString(),
                                sdr["EmpName"].ToString(),
                                sdr["Position"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["Address"].ToString());

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
        public List<employeeDTO> SearchEmployeeByName(string data)
        {
            List<employeeDTO> list = new List<employeeDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT EmpID,EmpName,Position,Phone, Address  FROM Employee WHERE EmpName like '%" + data + "%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            employeeDTO cus = new employeeDTO(
                                sdr["EmpIDID"].ToString(),
                                sdr["EmpName"].ToString(),
                                sdr["Position"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["Address"].ToString());

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
