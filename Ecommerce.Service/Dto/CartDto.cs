using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Service.Dto
{
    public class CartDto
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VoucherAmount { get; set; }
        public decimal TotalPrice { get; set; }
        [StringLength(7)]
        public string VoucherCode { get; set; }
        public Guid UserId { get; set; }
        public Guid PromotionId { get; set; }
    }
}
