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
    internal class productBUS
    {
        private productDAO product_DAO = new productDAO();
        public DataTable LayDSSanPham()
        {
            return product_DAO.LayDSSanPham();
        }
        public int LayMaSPMax()
        {
            return product_DAO.LayMaSPMax();
        }

        public bool isNameExisted(String productName)
        {
            return product_DAO.isProductNameExisted(productName);
        }
        public byte[] LayHinhSanPham(String productID)
        {
            return product_DAO.LayHinhSanPham(productID);
        }
        public bool CheckProductID(string productID)
        {
            return product_DAO.CheckProductID(productID);
        }
        public Boolean updateQuantityProduct(String productID, int newQuantity)
        {
            return product_DAO.UpdateProductQuantity(productID, newQuantity);
        }

        public Boolean updateQuantityPlus(String productID, int quantity)
        {
            return product_DAO.UpdateProductQuantityPlus(productID, quantity);
        }
        public bool ThemSanPham(productDTO product)
        {
            return product_DAO.ThemSanPham(product);
        }
        public bool XoaSanPham(string id)
        {
            return product_DAO.XoaSanPham(id);
        }
        public bool CapNhatSP(productDTO product)
        {
            return product_DAO.CapNhatSP(product);
        }
        public DataTable LayMaThuongHieu()
        {
            return product_DAO.LayMaThuongHieu();
        }
        public DataTable LayMaLoai()
        {
            return product_DAO.LayMaLoai();
        }
        public DataTable LayMaNCC()
        {
            return product_DAO.LayMaNCC();
        }
        public List<productDTO> searchProductByID(String data)
        {
            return product_DAO.SearchProductByID(data);
        }
        public List<productDTO> searchProductByName(String data)
        {
            return product_DAO.SearchProductByName(data);
        }
        public List<productDTO> SearchProductByNameAndPrice(string data, int minPrice, int maxPrice)
        {
            return product_DAO.SearchProductByNameAndPrice(data,minPrice, maxPrice);
        }
        public List<productDTO> SearchProductByNameAndPrice2(string data, int minPrice, int maxPrice)
        {
            return product_DAO.SearchProductByNameAndPrice2(data, minPrice, maxPrice);
        }
    }
}
