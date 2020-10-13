using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels
{
    public class ProductRateViewModel
    {
        public int Value { get; set; }

        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
