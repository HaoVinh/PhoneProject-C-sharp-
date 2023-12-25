using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class orderInfoDTO
    {
        private String productID;
        private String productName;
        private int unitPrice;
        private int quantity;
        private int Price;

        public orderInfoDTO(String productID, String productName, int unitPrice, int quantity, int Price)
        {
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.Price = Price;
        }

        public String getProductID()
        {
            return productID;
        }

        public void setProductID(String productID)
        {
            this.productID = productID;
        }

        public String getProductName()
        {
            return productName;
        }

        public void setProductName(String productName)
        {
            this.productName = productName;
        }

        public int getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getPrice()
        {
            return Price;
        }

        public void setPrice(int Price)
        {
            this.Price = Price;
        }
    }
}
