﻿using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class OrdersReponsitory : BaseRepository<TransactionHistory>, IOrdersRepository
    {
        public OrdersReponsitory(EcommerceDbContext dbContext) : base(dbContext)
        {

        }
        public Task<ICollection<TransactionHistory>> GetOrdersParrent()
        {
            throw new NotImplementedException();
        }
    }
}
