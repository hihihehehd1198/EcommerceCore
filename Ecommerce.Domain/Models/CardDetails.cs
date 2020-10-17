using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class CardDetails: BaseModel
    {
        public decimal Quantity{ get; set; }
        public decimal Price { get; set; }
        #region RelationShip
        //[ForeignKey("Product")]
        //public Guid ProductId { get; set; }
        //public virtual Product Product { get; set; }
        //[ForeignKey("Card")]
        //public Guid CartId { get; set; }
        //public virtual Cart Card { get; set; }
        [ForeignKey("Cart")]
        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        #endregion
    }
}
