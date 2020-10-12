using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
namespace Ecommerce.Repository.Interfaces
{
    public interface ITransactionHistoryRepository : IRepository<TransactionHistory>
    {
        Task<ICollection<TransactionHistory>> GetOrdersParrent();
    }
}
