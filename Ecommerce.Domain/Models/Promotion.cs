using Ecommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Transactions;

namespace Ecommerce.Domain.Models
{
    public class Promotion : BaseModel
    {
        [MaxLength(20)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool ApplyForAll { get; set; }
        public CalculateTypePromotion CalculateTypePromotion { get; set; }
        public decimal ValuePromotion { get; set; }
        public decimal? MaxMoneyForCode { get; set; }
        public PromotionStatus PromotionStatus { get; set; }

        #region Relationship
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }


        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        #endregion
    }
}
