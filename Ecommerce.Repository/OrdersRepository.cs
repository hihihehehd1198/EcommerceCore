using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(EcommerceDbContext dbContext) : base(dbContext)
        {

        }
        public Task<ICollection<Orders>> GetOrdersParrent()
        {
            throw new NotImplementedException();
        }
    }
}
