using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.ViewModels
{
    public class Login
    {
      
        public string email { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }
}
