using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;

namespace Ecommerce.Service.Services
{
    public class CategoryService : ConfigService<Category>, ICategoryService
    {
        private readonly ICategoryReponsitory _categoryReponsitory;       

        public CategoryService(ICategoryReponsitory categoryReponsitory) : base(categoryReponsitory)
        {
            _categoryReponsitory = categoryReponsitory;           
        }

        public Task<CategoryViewModel> GetCategoryForHomepage()
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<CategoryViewModel>> GetCategoryParrent()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
