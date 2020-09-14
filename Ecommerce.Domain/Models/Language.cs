using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Models
{
    public class Language: BaseModel
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }
        #region RelationShip
        public virtual ICollection<User> Users { get; set; }
        #endregion
    }
}
