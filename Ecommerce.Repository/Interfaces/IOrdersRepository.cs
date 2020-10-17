using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Interfaces
{
    public interface IOrdersRepository:IRepository<Orders>
    {
        Task<ICollection<Orders>> GetOrdersParrent();
    }
}
