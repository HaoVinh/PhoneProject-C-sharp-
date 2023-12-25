using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class supplierDTO
    {
        private String suppID;
        private String suppName;
        private String address;
        private String phone;
        private String contactPerson;

        public supplierDTO()
        {

        }

        public supplierDTO(string suppID, string suppName, string address, string phone, string contactPerson)
        {
            this.suppID = suppID;
            this.suppName = suppName;
            this.address = address;
            this.phone = phone;
            this.contactPerson = contactPerson;
        }

        public String getSuppID()
        {
            return this.suppID;
        }

        public String getSuppName()
        {
            return this.suppName;
        }

        public String getAddress()
        {
            return this.address;
        }

        
        public String getPhone()
        {
            return this.phone;
        }

        public String getContactPerson()
        {
            return this.contactPerson;
        }

        public void setSuppID(String suppID)
        {
            this.suppID = suppID;
        }

        public void setSuppName(String suppName)
        {
            this.suppName = suppName;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

      

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public void setContactPerson(String contactPerson)
        {
            this.contactPerson = contactPerson;
        }
    }
}

