using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyLightingBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock
    {

        bool UseConveyorSystem { get; }
        float Radius { get; } 
        float Intensity { get; } 
        float BlinkIntervalSeconds { get; } 
        float BlinkLenght { get; } 
        float BlinkOffset { get; }

    }
}
