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
    internal class supplierBUS
    {
        private supplierDAO sup_DAO = new supplierDAO();
        public DataTable LayDSNhaCC()
        {
            return sup_DAO.LayDSNhaCC();
        }
        public int LayMaNCCMax()
        {
            return sup_DAO.LayMaNCCMax();
        }
        public bool ThemNhaCC(supplierDTO sup)
        {
            return sup_DAO.ThemNhaCC(sup);
        }
        public bool XoaNhaCC(string id)
        {
            return sup_DAO.XoaNhaCC(id);
        }
        public bool CapNhatNhaCC(supplierDTO sup)
        {
            return sup_DAO.CapNhatNhaCC(sup);
        }
        public List<supplierDTO> searchSupplierByID(String data)
        {
            return sup_DAO.SearchSupplierByID(data);
        }
        public List<supplierDTO> searchSupplierByName(String data)
        {
            return sup_DAO.SearchSupplierByName(data);
        }
    }
}
