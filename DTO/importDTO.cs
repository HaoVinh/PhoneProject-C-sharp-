using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class importDTO
    {
        private String importID;
        private String suppID;
        private String date;
        private String empID;

        public importDTO(String importID, String suppID, String date, String empID)
        {
            this.importID = importID;
            this.suppID = suppID;
            this.date = date;
            this.empID = empID;
        }

        public String getImportID()
        {
            return importID;
        }

        public void setImportID(String importID)
        {
            this.importID = importID;
        }

        public String getSuppID()
        {
            return suppID;
        }

        public void setSuppID(String suppID)
        {
            this.suppID = suppID;
        }

        public String getDate()
        {
            return date;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getEmpID()
        {
            return empID;
        }

        public void setEmpID(String empID)
        {
            this.empID = empID;
        }
    }
}
