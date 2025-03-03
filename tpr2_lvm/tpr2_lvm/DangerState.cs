using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpr2_lvm
{
    internal class DangerState
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string FAL { get; set; }
        public List<InitEvent> InitEvents { get; set; }
        public double loss { get; set; }

    }
}
