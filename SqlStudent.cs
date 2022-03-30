using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlisWork
{
    internal class SqlStudent
    {
        public int StuId { get; set; }
        public string Name { get; set; }
            
        public int Grade { get; set; }

        public DateTime Birth { get; set; }

        public bool Married { get; set; }
    }
}
