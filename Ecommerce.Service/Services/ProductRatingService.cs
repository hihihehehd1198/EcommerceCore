using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Ecommerce.Core.Services;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Dto;
using Ecommerce.Service.Interface;
namespace Ecommerce.Service.Services
{
    public class ProductRatingService:Services<ProductRating>
    {
        private readonly IProductRatingRespository _productratingReponsitory;
        private readonly IMapper _mapper;

        public ProductRatingService(IProductRatingRespository productratingReponsitory, IMapper mapper) : base(productratingReponsitory)
        {
            _productratingReponsitory = productratingReponsitory;
            _mapper = mapper;
            this._productratingReponsitory = productratingReponsitory;
        }
    }
}
