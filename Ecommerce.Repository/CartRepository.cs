using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CartRepository:BaseRepository<Cart>,ICartRepository
    {
        public CartRepository(EcommerceDbContext dbContext) : base(dbContext)
        {

        }

        public Task<ICollection<Cart>> GetCartParrent()
        {
            throw new NotImplementedException();
        }
    }
}
