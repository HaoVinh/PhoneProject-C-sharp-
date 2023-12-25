using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class brandDTO
    {
        private String brandID;
        private String brandName;


        public brandDTO() { }   

        public brandDTO(String brandID, String brandName)
        {
            this.brandID = brandID;
            this.brandName = brandName;
        }
        public String getBrandID()
        {
            return brandID;
        }

        public void setBrandID(String brandID)
        {
            this.brandID = brandID;
        }

        public String getBrandName()
        {
            return brandName;
        }

        public void setBrandName(String brandName)
        {
            this.brandName = brandName;
        }
    }
}
