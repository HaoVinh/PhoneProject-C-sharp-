using MobileStore.DAO;
using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.BUS
{
    internal class reportBUS
    {
        private reportDAO report_DAO = new reportDAO();
        public int countEmployee()
        {
            return report_DAO.countEmployee();
        }
        public int countCustomer()
        {
            return report_DAO.countCustomer();
        }
        public int countProduct()
        {
            return report_DAO.countProduct();
        }
        public int countOrder()
        {
            return report_DAO.countOrder();
        }
        public int countSupplier()
        {
            return report_DAO.countSupplier();
        }
        public int countImport()
        {
            return report_DAO.countImport();
        }
        public List<reportImportDTO> reportImport(string start_time, string end_time, string field, string data, string date_format = "")
        {
            return report_DAO.ReportImport(start_time, end_time, field, data, date_format);
        }

        public List<reportSellDTO> reportSell(string start_time, string end_time, string field, string data, string date_format = "")
        {
            return report_DAO.ReportSell(start_time, end_time, field, data, date_format);
        }
    }
}
