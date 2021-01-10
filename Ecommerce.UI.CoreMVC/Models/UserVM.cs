using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Models
{
    public class UserVM
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
