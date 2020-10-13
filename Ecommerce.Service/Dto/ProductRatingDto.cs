using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.Dto
{
    class ProductRatingDto
    {
        #region Property
        public int Value { get; set; }
        #endregion
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
