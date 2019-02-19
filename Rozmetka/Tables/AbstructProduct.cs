using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozmetka.Tables
{
    class AbstructProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Catagory> Catagories { get; set; }
    }
}
