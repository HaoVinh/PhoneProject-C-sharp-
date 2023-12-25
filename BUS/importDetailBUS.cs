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
    internal class importDetailBUS
    {
        private importDetailDAO id_DAO = new importDetailDAO();
        public DataTable LayDSChiTietNhapHang()
        {
            return id_DAO.LayDSChiTietNhapHang();
        }
        public List<importDetailDTO> getOrderDetail(String importID)
        {
            return id_DAO.getOrderDetail(importID);
        }
        public bool CheckChiTietNhapHang(string importID, string productID)
        {
            return id_DAO.CheckChiTietNhapHang(importID,productID);
        }
        public bool ThemChiTietNhapHang(importDetailDTO id)
        {
            return id_DAO.ThemChiTietNhapHang(id);
        }

        public bool CapNhatChiTietHD(importDetailDTO id)
        {
            return id_DAO.CapNhatCTPN(id);
        }

    }
}
