using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Models
{
    public class Language
    {
        //[Required]
        //[MaxLength(20)]
        //public string Name { get; set; }

        //public bool IsDefault { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }


        #region RelationShip
        // public List<PromotionProduct> ProductTranslations { get; set; }
        // public virtual ICollection<User> Users { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        #endregion
    }
}
