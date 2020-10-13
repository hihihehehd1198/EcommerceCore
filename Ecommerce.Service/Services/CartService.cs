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
    public class CartService : ConfigService<Cart>, ICartServices
    {
        private readonly ICartRepository _cartReponsitory;

        public CartService(ICartRepository cartReponsitory) : base(cartReponsitory)
        {
            _cartReponsitory = cartReponsitory;
           
        }
        public Task<CartViewModel> GetNewCart()
        {
            throw new NotImplementedException();
        }
    }
}
