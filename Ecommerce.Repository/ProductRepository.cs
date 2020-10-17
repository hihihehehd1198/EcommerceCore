using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Common.Infrastructure.ViewModel.Admin.ViewModel;
using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<ProductAdminViewModel>> GetListProductAdminViewModel()
        {
            var listproduct = await (from p in DbContext.Products
                                     join c in DbContext.Categories on p.CategoryId equals c.Id
                                     join s in DbContext.Suppliers on p.SupplierId equals s.Id
                                     join m in DbContext.Manufacturers on p.ManufacturerId equals m.Id
                                     where p.IsDeleted == false
                                     select new ProductAdminViewModel
                                     {
                                         Name = p.Name,
                                         CategoryName = c.Name,
                                         SupplierName = s.Name,
                                         Price = p.Price,
                                         Description = p.Description,
                                         PublicationDate = p.PublicationDate,
                                         Keyword = p.Keyword,
                                         Sku = p.Sku,
                                         Views = p.Views,
                                         ManufacturerName = m.Name
                                     }).ToListAsync();
            return listproduct;
        }

        public async Task<List<Product>> GetProductByCategoryIdAndOrderByView(Guid categoryId)
        {

            var products = await DbContext.Products.Where(c => c.CategoryId == categoryId && c.Views >= 100).Take(100)
                .ToListAsync();
            return products;

            //sử dụng order by sắp xếp giảm dần rồi lấy 100 category lớn nhất
            //var products = await DbContext.Products.OrderByDescending(c => c.Views).Where(c => c.CategoryId == categoryId).Take(100)
            //    .ToListAsync();
            //return products;

        }

        public async Task<bool> GrowUpViewByProductId(Guid productId)
        {
            // get product by id
            var product = await GetByIdAsync(productId);
            if (product != null)
            {
                product.Views = product.Views + 1;
                await UpdateAsync(product);
                return true;
            }

            return false;
        }

    }
}
