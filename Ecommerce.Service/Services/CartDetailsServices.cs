using Ecommerce.Common.Infrastructure.ViewModel.Admin;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class CartDetailsServices:EcommerceServices<CardDetails>, ICartDetailsServices
    {
        private readonly ICartDetailsRepository _cartDetailsReponsitory;

        public CartDetailsServices(ICartDetailsRepository cartDetailsReponsitory) : base(cartDetailsReponsitory)
        {
            _cartDetailsReponsitory = cartDetailsReponsitory;
        }


    }
}
