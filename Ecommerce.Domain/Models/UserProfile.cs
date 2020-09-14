using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models
{
    public class UserProfile:BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthday { get; set;}

        #region Relationship
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        #endregion
    }
}
