using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface IMyTerminalBlock : IMyCubeBlock
    {

        String CustomName { get; }
        String CustomNameWithFaction { get; }
        String DetailedInfo { get; }
        bool ShowOnHUD { get; }

        bool HasLocalPlayerAccess();
        bool HasPlayerAccess(long playerId);
        void RequestShowOnHUD(bool enable);
        void SetCustomName(string text);
        void SetCustomName(StringBuilder text);
        void GetActions(List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null);
        void SearchActionsOfName(string name,List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null);
        ITerminalAction GetActionWithName(string name);

    }
}
