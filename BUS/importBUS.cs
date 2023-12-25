using MobileStore.DAO;
using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.BUS
{
    internal class importBUS
    {
        private importDAO imp_DAO = new importDAO();
        public DataTable LayDSNhapHang()
        {
            return imp_DAO.LayDSNhapHang();
        }
        public int LayMaPNMax()
        {
            return imp_DAO.LayMaPNMax();
        }
        public bool CheckImport(String importID)
        {
            return imp_DAO.CheckImport(importID);
        }
        public bool ThemNhapHang(importDTO id)
        {
            return imp_DAO.ThemNhapHang(id);
        }
        public List<importDTO> searchImport(String column, String data)
        {
            return imp_DAO.SearchImport(column, data);
        }
        public List<orderInfoDTO> getAllImportInfor(String orderID, String cusID, String empID)
        {
            return imp_DAO.getAllImportInfo(orderID, cusID, empID);
        }
    }
}
