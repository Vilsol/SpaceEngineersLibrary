using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyLargeTurretBase : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock
    {
        bool CanControl { get; }
        float Range { get; }
    }
}
