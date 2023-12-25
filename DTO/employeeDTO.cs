using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class employeeDTO
    {
        private String empID;
        private String empName;
        private String empPosition;
        private String empPhone;
        private String empAddress;
    


        public employeeDTO() { }

        public employeeDTO(String empID, String empName,String empPosition, String empPhone, String empAddress)
        {
            this.empID =empID;
            this.empName =empName;
            this.empPosition =empPosition;
            this.empPhone =empPhone;
            this.empAddress =empAddress;
        }
        public String getEmpID()
        {
            return empID;
        }

        public void setEmpID(String empID)
        {
            this.empID = empID;
        }

        public String getEmpName()
        {
            return empName;
        }

        public void setEmpName(String empName)
        {
            this.empName = empName;
        }
        public String getPosition()
        {
            return empPosition;
        }

        public void setPosition(String empPosition)
        {
            this.empPosition = empPosition;
        }
        public String getPhone()
        {
            return empPhone;
        }

        public void setPhone(String empPhone)
        {
            this.empPhone = empPhone;
        }


        public String getAddress()
        {
            return empAddress;
        }

        public void setAddress(String empAddress)
        {
            this.empAddress = empAddress;
        }
    }
}

