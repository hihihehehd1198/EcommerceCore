using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CartReponsitory:BaseRepository<Cart>,ICartRepository
    {
        public CartReponsitory(EcommerceDbContext dbContext) : base(dbContext)
        {

        }

        public Task<ICollection<Cart>> GetCartParrent()
        {
            throw new NotImplementedException();
        }
    }
}
