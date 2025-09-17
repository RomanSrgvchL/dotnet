using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance
{
    public interface IValidatable
    {
        bool IsValid {get; }
    }
}
