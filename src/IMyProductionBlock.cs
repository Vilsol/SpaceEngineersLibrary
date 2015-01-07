using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyProductionBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock
    {

        bool IsProducing { get; }
        bool IsQueueEmpty { get; }
        uint NextItemId { get; }
        bool UseConveyorSystem { get; }
        event Action StartedProducing;
        event Action StoppedProducing;
        void MoveQueueItemRequest(uint queueItemId, int targetIdx);
        void RemoveQueueItemRequest(int itemIdx);

    }
}
