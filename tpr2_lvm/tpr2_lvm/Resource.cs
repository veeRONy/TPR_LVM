using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpr2_lvm
{
    internal class Resource
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public List<DangerState> DangerStates { get; set; }
    }
}
