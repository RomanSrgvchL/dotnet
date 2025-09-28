using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.Exception
{
    public class InvalidRepairException : System.Exception
    {
        public InvalidRepairException()
        {
        }

        public InvalidRepairException(string message) : base(message)
        {
        }

        public InvalidRepairException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidRepairException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
