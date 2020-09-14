using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models
{
    public class Point:BaseModel
    {
        public int Count { get; set; }
        #region Relationship
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public Guid UserID { get; set; }


        #endregion
    }
}
