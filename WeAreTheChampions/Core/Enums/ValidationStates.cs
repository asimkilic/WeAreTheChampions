using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum ValidationStates
    {
        // Object validations vary according to deletion, update and insertion states.
        Delete=0,
        Add=1,
        Update=2
    }
}
