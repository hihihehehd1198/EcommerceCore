﻿using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Interfaces
{
    public interface IProductRatingRespository: IRepository<ProductRating>
    {

        Task<ICollection<ProductRating>> GetratingParrent();


    }
}
