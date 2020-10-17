using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;

namespace Ecommerce.Service.Services
{
    public class EcommerceService<T> : IServices<T> where T : class
    {
        private readonly IRepository<T> _baseRepository;

        public EcommerceService(IRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        #region Async

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await _baseRepository.FindAllAsync(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _baseRepository.FindAsync(match);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<T> AddAsync(T entity, bool isSave = true)
        {
            return await _baseRepository.AddAsync(entity, isSave);
        }

        public async Task<bool> AddManyAsync(IEnumerable<T> entities)
        {
            return await _baseRepository.AddManyAsync(entities);
        }

        public async Task UpdateAsync(T entity, bool isSave = true)
        {
            await _baseRepository.UpdateAsync(entity, isSave);
        }

        public async Task DeleteAsync(T entity, bool isSave)
        {
            await _baseRepository.DeleteAsync(entity, isSave);
        }

        #endregion

        #region Normal

        public T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _baseRepository.Find(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return _baseRepository.FindAll(match);
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool AddMany(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
