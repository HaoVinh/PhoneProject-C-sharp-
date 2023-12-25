using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class orderDTO
    {
        private String orderID;
        private String cusID;
        private String empID;
        private String orderDate;
        public orderDTO(String orderID, String cusID, String empID, String date)
        {
            this.orderID = orderID;
            this.cusID = cusID;
            this.empID = empID;
            this.orderDate = date;
        }

        public String getOrderID()
        {
            return orderID;
        }

        public void setOrderID(String orderID)
        {
            this.orderID = orderID;
        }

        public String getCusID()
        {
            return cusID;
        }

        public void setCusID(String cusID)
        {
            this.cusID = cusID;
        }

        public String getEmpID()
        {
            return empID;
        }

        public void setEmpID(String empID)
        {
            this.empID = empID;
        }

        public String getDate()
        {
            return orderDate;
        }

        public void setDate(String orderDate)
        {
            this.orderDate = orderDate;
        }
    }
}

