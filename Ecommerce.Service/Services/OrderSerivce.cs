using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Service.Interface;
using Ecommerce.Core.ViewModels;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Service.Services
{
    public class OrderSerivce 
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public OrderSerivce(
            ILoggerFactory loggerFactory,

            IMapper mapper)
        {
            _logger = loggerFactory.CreateLogger<OrderSerivce>();

            _mapper = mapper;
        }
    }
}