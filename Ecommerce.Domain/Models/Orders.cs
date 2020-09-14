using Ecommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Models
{
    public class Orders: BaseModel
    {
        public int Number { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VoucherAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string VoucherCode { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Init;
        [Required]
        [MaxLength(255)]
        public int Phone { get; set; }
        [Required]
        [MaxLength(255)]
        public string Province { get; set; }
        [Required]
        [MaxLength(255)]
        public string District { get; set; }
        [Required]
        [MaxLength(255)]
        public string Ward { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        #region RelationShip
        [ForeignKey("Promotion")]
        public Guid PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        #endregion

    }
}
