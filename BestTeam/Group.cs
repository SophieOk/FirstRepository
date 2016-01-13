using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTeam
{
    class Group
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<Student> Students { get; set; }
        public Faculty Faculty { get; set; }
    }
}
