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
    public class OrderSerivce : IPersonService
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        private readonly IPolicyRepository _policyRepository;
        private readonly IPersonRepository _personRepository;
        private readonly INominationRepository _nominationRepository;

        public OrderSerivce(
            ILoggerFactory loggerFactory,
            IPersonRepository personRepository,
            IMapper mapper)
        {
            _logger = loggerFactory.CreateLogger<OrderSerivce>();
            _personRepository = personRepository;
            _mapper = mapper;
        }
    }
}