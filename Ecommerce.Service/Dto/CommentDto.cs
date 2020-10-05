using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Service.Dto
{
    public class CommentDto
    {

        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [StringLength(120, ErrorMessage = "Max length is 120 char")]
        public string Description { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
