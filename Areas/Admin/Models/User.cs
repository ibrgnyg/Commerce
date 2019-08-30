using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string rePassword { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string activationCode { get; set; }
        public string resetCode { get; set; }
        public string hostName { get; set; }
        public bool isActive { get; set; }
        public int loginAttempt { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime loginTime { get; set; }
        public bool isMailVerified { get; set; }
        public int roleId { get; set; }
        public bool subscribe { get; set; }
        public string city { get; set; }

       
        //public virtual ICollection<favorim> favorim { get; set; }
        //public virtual role role { get; set; }
      
        //public virtual ICollection<siparis> siparis { get; set; }
      
        //public virtual ICollection<kamapanylar> Kamapanylar  { get; set; }
    }
}
