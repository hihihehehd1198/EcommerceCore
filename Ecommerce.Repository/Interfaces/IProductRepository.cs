using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.Common.Infrastructure.ViewModel.Admin.ViewModel;
using Ecommerce.Domain.Models;

namespace Ecommerce.Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetProductByCategoryIdAndOrderByView(Guid categoryId);
        Task<bool> GrowUpViewByProductId(Guid productId);
        //lay ra danh sach product
        Task<List<ProductAdminViewModel>> GetListProductAdminViewModel();
    } 
   
}
