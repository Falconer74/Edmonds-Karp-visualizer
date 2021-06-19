using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public enum EdgeStatus
    {
        Default = 0,
        Saturated,
        Inspected,
        Choosen,
        Bottleneck
    }

    public enum VertexStatus
    {
        Default = 0,
        Inspected,
        Choosen,
    }
}
