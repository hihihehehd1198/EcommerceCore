using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(EcommerceDbContext dbContext) : base(dbContext)
        {

        }

        public TransactionHistory Add(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionHistory> AddAsync(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public bool AddMany(IEnumerable<TransactionHistory> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddManyAsync(IEnumerable<TransactionHistory> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<TransactionHistory> entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(List<TransactionHistory> entity)
        {
            throw new NotImplementedException();
        }

        public TransactionHistory Find(Expression<Func<TransactionHistory, bool>> match)
        {
            throw new NotImplementedException();
        }

        public ICollection<TransactionHistory> FindAll(Expression<Func<TransactionHistory, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TransactionHistory>> FindAllAsync(Expression<Func<TransactionHistory, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionHistory> FindAsync(Expression<Func<TransactionHistory, bool>> match)
        {
            throw new NotImplementedException();
        }

        public TransactionHistory GetFirstOrDefault(Expression<Func<TransactionHistory, bool>> predicate, Func<IQueryable<TransactionHistory>, IOrderedQueryable<TransactionHistory>> orderBy = null, Func<IQueryable<TransactionHistory>, IIncludableQueryable<TransactionHistory, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public TransactionHistory GetFirstOrDefaultAsync(Expression<Func<TransactionHistory, bool>> predicate, Func<IQueryable<TransactionHistory>, IOrderedQueryable<TransactionHistory>> orderBy = null, Func<IQueryable<TransactionHistory>, IIncludableQueryable<TransactionHistory, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Orders>> GetOrdersParrent()
        {
            throw new NotImplementedException();
        }

        public void Update(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TransactionHistory entity, bool isSave)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<TransactionHistory> entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<TransactionHistory> entity)
        {
            throw new NotImplementedException();
        }

        //IQueryable<TransactionHistory> IRepository<TransactionHistory>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IQueryable<TransactionHistory>> IRepository<TransactionHistory>.GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //TransactionHistory IRepository<TransactionHistory>.GetById(Guid Id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<TransactionHistory> IRepository<TransactionHistory>.GetByIdAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<ICollection<TransactionHistory>> IOrdersRepository.GetOrdersParrent()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
