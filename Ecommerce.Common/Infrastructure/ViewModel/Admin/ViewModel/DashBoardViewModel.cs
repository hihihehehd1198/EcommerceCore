using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace EcommerceCommon.Infrastructure.ViewModel
{
    public class DashBoardViewModel
    {
        public int TotalOrder { get; set; }
        public int UserRegister { get; set; }
        public int ProductNew { get; set; }
        public decimal TotalInComeSystem { get; set; }
        public List<ProductViewMostViewModel> ProductViewMostViewModels { get; set; }       
        public List<OrderNewViewModel> OrderNewViewModels { get; set; }
    }

    public class ProductViewMostViewModel
    {
        public Guid  ProductId { get; set; }
        public string  Title { get; set; }
        public int  Views { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
    }

    public class OrderNewViewModel
    {
        public Guid OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
    }
}
