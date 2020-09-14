using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Models
{
    public class Comment: BaseModel
    {
        [MaxLength(30)]
        public string Content { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        #region RelationShip
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
