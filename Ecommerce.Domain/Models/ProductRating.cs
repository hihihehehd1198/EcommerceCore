using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Models
{
    public class ProductRating : BaseModel
    {

        public RatingEnum Rating { get; set; }

        #region Relationship
        [ForeignKey("Product")]
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public virtual User User { get; set; }

        #endregion
    }

}
