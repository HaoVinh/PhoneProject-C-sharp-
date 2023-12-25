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
    internal class employeeBUS
    {
        private employeeDAO emp_DAO = new employeeDAO();
        public DataTable LayDSNhanvien()
        {
            return emp_DAO.LayDSNhanvien();
        }
        public int LayMaNVMax()
        {
            return emp_DAO.LayMaNVMax();
        }
        public DataTable LayDSMaNhanVien()
        {
            return emp_DAO.LayMaNhanVien();
        }
        public bool ThemNhanVien(employeeDTO emp)
        {
            return emp_DAO.ThemNhanVien(emp);
        }
        public bool XoaNhanVien(string id)
        {
            return emp_DAO.XoaNhanVien(id);
        }
        public bool CapNhatNV(employeeDTO emp)
        {
            return emp_DAO.CapNhatNV(emp);
        }
        public List<employeeDTO> searchEmployeeByID(String data)
        {
            return emp_DAO.SearchEmployeeByID(data);
        }
        public List<employeeDTO> searchEmployeeByName(String data)
        {
            return emp_DAO.SearchEmployeeByName(data);
        }
    }
}
