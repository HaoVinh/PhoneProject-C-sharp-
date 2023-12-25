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
    internal class brandBUS
    {
        private brandDAO brand_DAO = new brandDAO();
        public DataTable LayDSTH()
        {
            return brand_DAO.LayDSTH();
        }
        public int LayMaTHMax()
        {
            return brand_DAO.LayMaTHMax();
        }
        
        public bool ThemTH(brandDTO brand)
        {
            return brand_DAO.ThemThuongHieu(brand);
        }
        
        public bool XoaTH(string id)
        {
            return brand_DAO.XoaThuongHieu(id);
        }
        public bool CapNhatTH(brandDTO brand)
        {
            return brand_DAO.CapNhatThuongHieu(brand);
        }
        public List<brandDTO> searchBrandByID(String data)
        {
            return brand_DAO.SearchBrandByID(data);
        }
        public List<brandDTO> searchBrandByName(String data)
        {
            return brand_DAO.SearchBrandByName(data);
        }
    }
}
