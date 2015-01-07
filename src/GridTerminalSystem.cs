using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public class GridTerminalSystem
    {

        List<IMyTerminalBlock> Blocks { get { throw new NotImplementedException(); }}
        List<IMyBlockGroup> BlockGroups { get { throw new NotImplementedException(); }}

        public static void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null) {}
        public static void SearchBlocksOfName(string name, List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null) {}
        public static IMyTerminalBlock GetBlockWithName(string name) { return null; }

    }
}
