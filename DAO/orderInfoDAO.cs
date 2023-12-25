using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class orderInfoDAO
    {
        Database db;
        public orderInfoDAO()
        {
            db = new Database();
        }
        public List<orderInfoDTO> getAllOrderInfo(String orderID, String cusID, String empID)
        {
            List<orderInfoDTO> list = new List<orderInfoDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT orde.ProductID, product.ProductName, product.UnitPrice, orde.Quantity, orde.Price " +
                     "FROM Orders AS o, OrderDetailID AS orde, Product AS product " +
                     "WHERE o.OrderID = orde.OrderID AND orde.ProductID = product.ProductID AND o.OrderID = '" + orderID + "' AND o.CustomerID = '" + cusID + "' AND o.EmpID = '" + empID + "'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            String cakeID = sdr["ProductID"].ToString();
                            String cakeName = sdr["ProductName"].ToString();
                            int unitPrice = int.Parse(sdr["UnitPrice"].ToString());
                            int quantity = int.Parse(sdr["Quantity"].ToString());
                            int price = int.Parse(sdr["Price"].ToString());
                            orderInfoDTO infor = new orderInfoDTO(cakeID, cakeName, unitPrice, quantity, price);
                            list.Add(infor);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return list;

        }

          
        }
    }


