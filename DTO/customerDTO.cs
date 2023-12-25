using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class customerDTO
    {
        private String cusID;
        private String cusName;
        private String cusPhone;
        private String cusAddress;
        

        public customerDTO() { }

        public customerDTO(String cusID, String cusName, String cusPhone, String cusAddress )
        {
           this.cusID = cusID;
           this.cusName = cusName;
           this.cusPhone = cusPhone;
           this.cusAddress = cusAddress;
        }
        public String getCusID()
        {
            return cusID;
        }

        public void setCusID(String cusID)
        {
            this.cusID = cusID;
        }

        public String getCusName()
        {
            return cusName;
        }

        public void setCusName(String cusName)
        {
            this.cusName = cusName;
        }

        public String getPhone()
        {
            return cusPhone;
        }

        public void setPhone(String cusPhone)
        {
            this.cusPhone = cusPhone;
        }


        public String getAddress()
        {
            return cusAddress;
        }

        public void setAddress(String cusAddress)
        {
            this.cusAddress = cusAddress;
        }
    }
}

