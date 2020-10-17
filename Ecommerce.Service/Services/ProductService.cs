
using Ecommerce.Common.Infrastructure.ViewModel;
using Ecommerce.Common.Infrastructure.ViewModel.Admin.ViewModel;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class ProductService : EcommerceServices<Product>,IProductSevice
    {
        private readonly IProductRepository _productReponsitory;

        public ProductService(IProductRepository productReponsitory) : base(productReponsitory)
        {
            _productReponsitory = productReponsitory;
        }

        public async Task<List<ProductAdminViewModel>> GetListProduct()
        {
            return await _productReponsitory.GetListProductAdminViewModel();
        }
    }
}
