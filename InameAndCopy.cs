using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLab3
{
    interface InameAndCopy
    {
        string Name { get; set; }
        object DeepCopy();
    }
}
