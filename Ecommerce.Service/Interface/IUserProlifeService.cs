using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.Interface
{
    public interface IUserProfileService : IServices<UserProfile>
    {

        //IEnumerable<User> GetAll();
        //User GetById(int id);
        void Create(UserProfile profile);
        void Delete(Guid id);
    }
}
