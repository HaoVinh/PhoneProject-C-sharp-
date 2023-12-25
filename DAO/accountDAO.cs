using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MobileStore.DAO
{
    internal class accountDAO
    {
        Database db;
        public accountDAO()
        {
            db = new Database();
        }
        public DataTable LayDSTaiKhoan()
        {
            string strSQL = "Select * From Account acc";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayPermission()
        {
            string strSQL = "Select Permission From Account acc";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaTKMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(AccID, 3, LEN(AccID) - 2) AS INT)) AS MaxAccNumber FROM Account";

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
        public accountDTO.Permission checkLogin(string username, string password)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "select * from Account where UserName ='" + username + "' and Password ='" + password + "'";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            if ((int)sdr["Permission"] == 1)
                            {
                                return accountDTO.Permission.Manager;
                            }
                            else if ((int)sdr["Permission"] == 0)
                            {
                                return accountDTO.Permission.Employee;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return accountDTO.Permission.None;
        }
        public employeeDTO getInfoEmp(String username, String password)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            String empId = ""
                , empname = ""
                , position = ""
                , phone = ""
                , address = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "SELECT emp.EmpID, EmpName, Position, Phone, Address FROM Account AS acc, Employee AS emp WHERE acc.EmpId = emp.EmpID AND acc.UserName = '" + username + "' AND acc.Password = '" + password + "'";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            empId = sdr["EmpID"].ToString();
                            empname = sdr["EmpName"].ToString();
                            position = sdr["Position"].ToString();
                           
                            phone = sdr["Phone"].ToString();
                            address = sdr["Address"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            employeeDTO emp = new employeeDTO(empId, empname, position, phone, address);
            return emp;
        }
        public bool CheckAccountExistForEmployee(string empID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE EmpID = @EmpID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpID", empID);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public string GetAccountIDByEmployeeID(string empID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT AccID FROM Account WHERE EmpID = @EmpID";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmpID", empID);

                    object result = command.ExecuteScalar();

                    // Check if result is not null and convert it to string
                    return result != null ? result.ToString() : null;
                }
            }
        }
        public bool ThemTaiKhoan(accountDTO acc)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Account (AccID, UserName, Password, EmpID, Permission) VALUES (@AccID, @UserName, @Password, @EmpID, @Permission)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@AccID", acc.AccID);
                    command.Parameters.AddWithValue("@UserName", acc.UserName);
                    command.Parameters.AddWithValue("@Password", acc.Password);
                    command.Parameters.AddWithValue("@EmpID", acc.EmpID);

                    int permission = 0;
                    if (acc.AccountPermission.Equals(accountDTO.Permission.Employee))
                    {
                        permission = 0;
                    }
                    else if (acc.AccountPermission.Equals(accountDTO.Permission.Manager))
                    {
                        permission = 1;
                    }
                    command.Parameters.AddWithValue("@Permission", permission);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }

        public bool XoaTaiKhoan(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Account WHERE AccID = @AccID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@AccID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatTaiKhoan(accountDTO acc)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Account SET EmpID=@EmpID,UserName=@UserName,Password=@Password,Permission=@Permission where AccID=@AccID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmpID", acc.EmpID);
                    command.Parameters.AddWithValue("@UserName", acc.UserName);
                    command.Parameters.AddWithValue("@Password", acc.Password);
                    int permission = 0;
                    if (acc.AccountPermission.Equals(accountDTO.Permission.Employee))
                    {
                        permission = 0;
                    }
                    else if (acc.AccountPermission.Equals(accountDTO.Permission.Manager))
                    {
                        permission = 1;
                    }
                    command.Parameters.AddWithValue("@Permission", permission);
                    command.Parameters.AddWithValue("@AccID", acc.AccID);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
    }
}
