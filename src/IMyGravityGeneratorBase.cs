using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyGravityGeneratorBase : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock
    {
        float Gravity { get; }
    }
}
