using Ecommerce.Common.Infrastructure.ViewModel.Admin;
using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CartDetailsRepository : BaseRepository<CardDetails>, ICartDetailsRepository
    {
        public CartDetailsRepository(EcommerceDbContext dbContext) : base(dbContext)
        {
        }

    }
}
