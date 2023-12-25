using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class importDetailDTO
    {
        private String importID;
        private String productID;
        private int quantity;
        private int unitprice;

        public importDetailDTO(String importID, String productID, int quantity, int unitprice)
        {
            this.importID = importID;
            this.productID = productID;
            this.quantity = quantity;
            this.unitprice = unitprice;
        }

     
        public String getImportID()
        {
            return importID;
        }

        public void setImportID(String importID)
        {
            this.importID = importID;
        }

        public String getProductID()
        {
            return productID;
        }

        public void setProductID(String productID)
        {
            this.productID = productID;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getUnitprice()
        {
            return unitprice;
        }

        public void setUnitprice(int unitprice)
        {
            this.unitprice = unitprice;
        }
    }
}

