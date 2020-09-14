using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Enums;
using Ecommerce.Domain.Models;

namespace Ecommerce.Domain.Models
{
    public class TransactionHistory:BaseModel
    {
        public Guid Number { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal VoucherAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid VoucherCode { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        #region RelationShip
        [ForeignKey("Promotion")]
        public Guid PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        //public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<HistoryDetail> HistoryDetails { get; set; }
        #endregion
    }

}
