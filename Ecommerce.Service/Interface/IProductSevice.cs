using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels;

namespace Ecommerce.Service.Interface
{
    public  interface IProductSevice : IServices<Product>
    {
        Task<List<ProductViewModel>> GetProductByCategoryIdAndOrderByView(Guid categoryId);
        Task<bool> GrowUpViewByProductId(Guid productId);

        // Lấy ra các sản phẩm mới nhất (trong vòng 7 ngày)
        Task<ProductViewModel> GetNewProduct();

        // Lấy ra những sản phẩm hot trend (Lượt xem nhiều nhất và số lượng mua nhiều nhất)
        Task<ProductViewModel> GetHotTrendProduct();

        // Lấy ra những sản phẩm đang được giảm giá nhiếu nhất
        Task<ProductViewModel> GetDiscountProduct();
    }
}
