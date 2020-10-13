using Ecommerce.Domain.Models;
using Ecommerce.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.Interface
{
    public interface IConfigService:IServices<Config>
    {
        //IEnumerable<User> GetAll();
        //User GetById(int id);
        Config Create(Config config, string code, string value);
        void Update(Config config, string code = null);
        void Delete(Guid id);
    }
}
