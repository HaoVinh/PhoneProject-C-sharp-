using MobileStore.DAO;
using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.BUS
{
    internal class orderInfoBUS
    {
        private orderInfoDAO orderInforDAO = new orderInfoDAO();

        public List<orderInfoDTO> getAllOrderInfor(String orderID, String cusID, String empID)
        {
            return orderInforDAO.getAllOrderInfo(orderID, cusID, empID);
        }
    }
}
