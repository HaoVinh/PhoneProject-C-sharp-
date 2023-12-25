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
    internal class ordDetailBUS
    {
        private ordDetailDAO od_DAO = new ordDetailDAO();
        public DataTable LayDSChiTietHoaDon()
        {
            return od_DAO.LayDSChiTietHoaDon();
        }
        public List<orderDetailDTO> getOrderDetail(String orderID)
        {
            return od_DAO.getOrderDetail(orderID);
        }
        public Boolean checkOrderDetail(String orderID, String cakeID)
        {
            return od_DAO.CheckChiTietHoaDon(orderID, cakeID);
        }
        public bool ThemChiTietHoaDon(orderDetailDTO od)
        {
            return od_DAO.ThemChiTietHoaDon(od);
        }
        
        public bool CapNhatChiTietHD(orderDetailDTO od)
        {
            return od_DAO.CapNhatCTHD(od);
        }
        //public List<orderDTO> searchOrder(String column, String data)
        //{
        //    return od_DAO.SearchOrder(column, data);
        //}
    }
}
