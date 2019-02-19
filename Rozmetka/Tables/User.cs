using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozmetka.Tables
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }        
        public int Age { get; set; }
        public string Email { get; set; }
        public virtual Status Status { get; set; }
        public virtual Status Gender { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
