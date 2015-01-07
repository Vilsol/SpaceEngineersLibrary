using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{
    public interface ITerminalAction
    {

        String Id { get; }
        StringBuilder Name { get; }

        void Apply(IMyCubeBlock block);

    }
}
