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
    internal class accountBUS
    {
        private accountDAO acc_DAO = new accountDAO();
        public DataTable LayDSTaiKhoan()
        {
            return acc_DAO.LayDSTaiKhoan();
        }
        public int LayMaTKMax()
        {
            return acc_DAO.LayMaTKMax();
        }
        public DataTable LayPermission()
        {
            return acc_DAO.LayPermission();
        }
        public accountDTO.Permission checkLogin(String userName, String password)
        {
            return acc_DAO.checkLogin(userName, password);
        }
        public bool CheckAccountExistForEmployee(string empID)
        {
            return acc_DAO.CheckAccountExistForEmployee(empID);
        }
        public string GetAccountIDByEmployeeID(string empID)
        {
            return acc_DAO.GetAccountIDByEmployeeID(empID);
        }
        public employeeDTO getInfoEmp(String userName , String password)
        {
            return acc_DAO.getInfoEmp(userName,password);
        }
        public bool ThemTaiKhoan(accountDTO acc)
        {
            return acc_DAO.ThemTaiKhoan(acc);
        }
        public bool XoaNhanVien(string id)
        {
            return acc_DAO.XoaTaiKhoan(id);
        }
        public bool CapNhatNV(accountDTO acc)
        {
            return acc_DAO.CapNhatTaiKhoan(acc);
        }
    }
}
