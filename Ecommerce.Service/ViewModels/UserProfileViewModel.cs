using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels
{
    public class UserProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthday { get; set; }


        public Guid UserId { get; set; }


    }
}
