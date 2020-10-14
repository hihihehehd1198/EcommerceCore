using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class CartService : EcommerceService<Cart>, ICartServices
    {
        private readonly ICartRepository _cartRepository;
        //private readonly IMapper _mapper;

        public CartService(ICartRepository cartRepository) : base(cartRepository)
        {
            _cartRepository = cartRepository;
            //_mapper = mapper;

        }
        public Task<CartViewModel> GetNewCart()
        {
            throw new NotImplementedException();
        }
    }
}
