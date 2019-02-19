using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozmetka.Tables
{
    class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLegal { get; set; }
        public virtual AbstructProduct AbstructProduct { get; set; }
    }
}
