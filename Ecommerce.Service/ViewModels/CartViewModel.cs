using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels
{
    public class CartViewModel
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VoucherAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string VoucherCode { get; set; }
        public Guid UserId { get; set; }
        public Guid PromotionId { get; set; }
    }
}
