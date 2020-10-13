using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Service.Interface;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using System.Linq.Expressions;
using System.Linq;

namespace Ecommerce.Core.Services
{
    //public class Service // :PolicyService
    //{
    //    //private readonly ILogger _logger;
    //    //private readonly IMapper _mapper;

    //    //private readonly IPolicyRepository _policyRepository;
    //    //private readonly IPersonRepository _personRepository;
    //    //private readonly INominationRepository _nominationRepository;

    //    public Service()
    //        //ILoggerFactory loggerFactory,
    //        //IPolicyRepository policyRepository,
    //        //IPersonRepository personRepository,
    //        //INominationRepository nominationRepository,
    //        //IMapper mapper)
    //    {
    //        //_logger = loggerFactory.CreateLogger<PolicyService>();
    //        //_policyRepository = policyRepository;
    //        //_personRepository = personRepository;
    //        //_nominationRepository = nominationRepository;
    //        //_mapper = mapper;
    //    }

    //    public async Task Create(PolicyViewModel model, string userId)
    //    {
    //        // var policyId = Guid.Empty;
    //     //   var policyToSave = _mapper.Map<Policy>(model);
    //        // policyToSave.Id = policyId;

    //        // //save policy owner
    //        // var owner = _mapper.Map<Person>(model.Owner);
    //        // var savedOwner = await _personRepository.AddAsync(owner);
    //        // policyToSave.OwnerFK = savedOwner.Id;

    //        // //save policy spouse if any
    //        // if(model.Spouse != null) 
    //        // {
    //        //     var spouse = _mapper.Map<Person>(model.Spouse);
    //        //     var savedSpouse = await _personRepository.AddAsync(spouse);
    //        //     policyToSave.SpouseFK = savedSpouse.Id;
    //        // }

    //        //save nominations
    //        // var nominations = _mapper.Map<IList<Nomination>>(model.Nominations);
    //        // var nominationSaved = await _nominationRepository.AddManyAsync(nominations);

    //        //save policy
    //       // await _policyRepository.AddAsync(policyToSave);
    //    }

    //    public async Task<PolicyViewModel> GetById(Guid id, string userId)
    //    {
    //        //_logger.LogInformation($"PolicyService.GetById called. id={id}; userId={userId}");

    //        //try
    //        //{
    //        //    var policy = await _policyRepository.GetByIdAsync(id);

    //        //    if(policy == null)
    //        //    {
    //        //        return null;
    //        //    }

    //        //    return _mapper.Map<PolicyViewModel>(policy);
    //        //}
    //        //catch (Exception exception)
    //        //{
    //        //    _logger.LogError(exception, $"Error when calling PolicyService.GetById. id={id}; userId={userId}");
    //        //    throw;
    //        //}
    //        return null;
    //    }

    //    public async Task<PolicyViewModel> GetByPolicyNo(string policyNo, string userId)
    //    {
    //        //_logger.LogInformation($"PolicyService.GetByPolicyNo called. id={policyNo}; userId={userId}");

    //        //try
    //        //{
    //        //    var policy = await _policyRepository.GetByPolicyNoAsync(policyNo);

    //        //    if(policy == null)
    //        //    {
    //        //        return null;
    //        //    }

    //        //    return _mapper.Map<PolicyViewModel>(policy);
    //        //}
    //        //catch (Exception exception)
    //        //{
    //        //    _logger.LogError(exception, $"Error when calling PolicyService.GetByPolicyNo. id={policyNo}; userId={userId}");
    //        //    throw;
    //        //}

    //        return null;
    //    }

    //    public Task Update(PolicyViewModel model, string userId)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class Services<T> : IServices<T> where T : class
    {
        private readonly IRepository<T> _baseReponsitory;

        public Services(IRepository<T> baseReponsitory)
        {
            _baseReponsitory = baseReponsitory;
        }

        #region Async

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await _baseReponsitory.FindAllAsync(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _baseReponsitory.FindAsync(match);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _baseReponsitory.GetByIdAsync(id);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await _baseReponsitory.GetAllAsync();
        }

        public async Task<T> AddAsync(T entity, bool isSave = true)
        {
            return await _baseReponsitory.AddAsync(entity, isSave);
        }

        public async Task<bool> AddManyAsync(IEnumerable<T> entities)
        {
            return await _baseReponsitory.AddManyAsync(entities);
        }

        public async Task UpdateAsync(T entity, bool isSave = true)
        {
            await _baseReponsitory.UpdateAsync(entity, isSave);
        }

        public async Task DeleteAsync(T entity, bool isSave)
        {
            await _baseReponsitory.DeleteAsync(entity, isSave);
        }

        #endregion

        #region Normal

        public T GetById(Guid id)
        {
            return _baseReponsitory.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return _baseReponsitory.GetAll();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _baseReponsitory.Find(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return _baseReponsitory.FindAll(match);
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