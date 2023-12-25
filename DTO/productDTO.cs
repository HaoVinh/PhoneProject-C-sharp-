using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class productDTO
    {
        private String productID;
        private String productName;
        private int unitPrice;
        private int quantity;
        private String brandID;
        private String categoryID;
        private byte[] imageData;
        public productDTO(String productID, String productName, int unitPrice, int quantity, String brandID, String categoryID, byte[] ImageData)
        {
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.brandID = brandID;
            this.categoryID = categoryID;
            this.imageData = ImageData;
        }



        public String getproductID()
        {
            return productID;
        }

        public void setproductID(String productID)
        {
            this.productID = productID;
        }

        public String getproductName()
        {
            return productName;
        }

        public void setproductName(String productName)
        {
            this.productName = productName;
        }

        public String getCategoryID()
        {
            return categoryID;
        }

        public void setCategoryID(String categoryID)
        {
            this.categoryID = categoryID;
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

        public String getBrandID()
        {
            return brandID;
        }

        public void setBrandID(String brandID)
        {
            this.brandID = brandID;
        }

        public byte[] GetImageData()
        {
            return imageData;
        }

        public void SetImageData(byte[] imageData)
        {
            this.imageData = imageData;
        }
    }
}

