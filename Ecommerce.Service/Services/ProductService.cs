using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;

namespace Ecommerce.Service.Services
{
    public class ProductService : ConfigService<Product>, IProductSevice
    {
        private readonly IProductRepository _productReponsitory;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productReponsitory, IMapper mapper) : base(productReponsitory)
        {
            _productReponsitory = productReponsitory;
            _mapper = mapper;
            this._productReponsitory = productReponsitory;
        }

        public Task<ProductViewModel> GetDiscountProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetHotTrendProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetNewProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetProductByCategoryIdAndOrderByView(Guid categoryId)
        {
            var product = await _productReponsitory.GetProductByCategoryIdAndOrderByView(categoryId);
            return _mapper.Map<List<ProductViewModel>>(product);
        }

        public async Task<bool> GrowUpViewByProductId(Guid productId)
        {
            return await _productReponsitory.GrowUpViewByProductId(productId);
        }
    }
}
