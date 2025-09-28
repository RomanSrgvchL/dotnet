using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.Exception
{
    public class InvalidRepairTypeException : System.Exception
    {
        public InvalidRepairTypeException()
        {
        }

        public InvalidRepairTypeException(string message) : base(message)
        {
        }

        public InvalidRepairTypeException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidRepairTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
