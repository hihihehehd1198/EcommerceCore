using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Service.Dto
{
    public class OrdersDto
    {
        public Guid Id { get; set; }

        public int Number { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VoucherAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string VoucherCode { get; set; }
        public int OrderStatus { get; set; }
        [Required(ErrorMessage = "Field is required")]
        
        public int Phone { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string Province { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string District { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string Ward { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string Address { get; set; }
        public Guid UserId { get; set; }
        public Guid PromotionId { get; set; }
    }
}
