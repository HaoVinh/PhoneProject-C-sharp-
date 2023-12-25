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
    internal class orderBUS
    {
        private orderDAO order_DAO = new orderDAO();
        public DataTable LayDSHoaDon()
        {
            return order_DAO.LayDSHoaDon();
        }
        public int LayMaHDMax()
        {
            return order_DAO.LayMaHDMax();
        }
        public bool CheckOrder(String orderID)
        {
            return order_DAO.CheckOrder(orderID);
        }
        public bool ThemHoaDon(orderDTO order)
        {
            return order_DAO.ThemHoaDon(order);
        }
        public bool XoaHoaDon(string id)
        {
            return order_DAO.XoaHoaDon(id);
        }
        public bool CapNhatHD(orderDTO order)
        {
            return order_DAO.CapNhatHD(order);
        }
        public List<orderDTO> searchOrder(String column ,String data)
        {
            return order_DAO.SearchOrder(column,data);
        }
    }
}
