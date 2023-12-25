using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class reportImportDTO
    {
        private string productId;
        private string productName;
        private string productType;
        private string date;
        private string supplier;
        private int quantity;
        private int totalPrice;
        public reportImportDTO() { }
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public string ProductType { get => productType; set => productType = value; }
        public string Date { get => date; set => date = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
