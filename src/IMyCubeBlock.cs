using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyCubeBlock
    {

        bool IsBeingHacked { get; }
        bool IsFunctional { get; }
        bool isWorking { get; }
        VRageMath.Vector3I Position { get; }

    }
}
