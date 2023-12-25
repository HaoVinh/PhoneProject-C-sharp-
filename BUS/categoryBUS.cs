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
    internal class categoryBUS
    {
        private categoryDAO cate_DAO = new categoryDAO();
        public DataTable LayDSLoai()
        {
            return cate_DAO.LayDSLoai();
        }
        public int LayMaTLMax()
        {
            return cate_DAO.LayMaTLMax();
        }
        public bool ThemLoai(categoryDTO cate)
        {
            return cate_DAO.ThemLoai(cate);
        }
        public bool XoaLoai(string id)
        {
            return cate_DAO.XoaLoai(id);
        }
        public bool CapNhatLoai(categoryDTO cate)
        {
            return cate_DAO.CapNhatLoai(cate);
        }
        public List<categoryDTO> searchCategoryByID(String data)
        {
            return cate_DAO.SearchCategoryByID(data);
        }
        public List<categoryDTO> searchCategoryByName(String data)
        {
            return cate_DAO.SearchCategoryByName(data);
        }
    }
}
