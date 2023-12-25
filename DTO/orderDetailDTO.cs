using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class orderDetailDTO
    {
        private String orderID;
        private String productID;
        private int price;
        private int quantity;

        public orderDetailDTO(string orderID, string productID, int price, int quantity)
        {
            this.orderID = orderID;
            this.productID = productID;
            this.price = price;
            this.quantity = quantity;
        }

        public String getOrderID()
        {
            return this.orderID;
        }

        public String getProductID()
        {
            return this.productID;
        }


        public int getPrice()
        {
            return this.price;
        }
        public int getQuantity()
        {
            return this.quantity;
        }

        public void setOrderID(String orderID)
        {
            this.orderID = orderID;
        }

        public void setProductID(String productID)
        {
            this.productID = productID;
        }


        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
