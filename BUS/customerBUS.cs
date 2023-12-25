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
    internal class customerBUS
    {
        private customerDAO cus_DAO = new customerDAO();
        public DataTable LayDSNhanvien()
        {
            return cus_DAO.LayDSNhanvien();
        }
        public int LayMaKHMax()
        {
            return cus_DAO.LayMaTHMax();
        }
        public List<customerDTO> getAllCustomer()
        {
            return cus_DAO.getAllCustomer();
        }
        public DataTable LayManhanvien()
        {
            return cus_DAO.LayMaNhanvien();
        }
        public bool ThemNhanVien(customerDTO cus)
        {
            return cus_DAO.ThemNhanVien(cus);
        }
        public bool XoaNhanVien(string id)
        {
            return cus_DAO.XoaNhanVien(id);
        }
        public bool CapNhatNV(customerDTO cus)
        {
            return cus_DAO.CapNhatNV(cus);
        }
        public List<customerDTO> searchCustomerByID(String data)
        {
            return cus_DAO.SearchCustomerByID(data);
        }
        public List<customerDTO> searchCustomerByName(String data)
        {
            return cus_DAO.SearchCustomerByName(data);
        }
    }
}
