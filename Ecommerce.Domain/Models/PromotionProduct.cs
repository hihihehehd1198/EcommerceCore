using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class PromotionProduct : BaseModel
    {
        [ForeignKey("Promotion")]
        public Guid PromotionID { get; set; }
        public virtual Promotion Promotion { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
