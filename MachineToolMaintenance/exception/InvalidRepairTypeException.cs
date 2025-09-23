using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.exception
{
    public class InvalidRepairTypeException : Exception
    {
        public InvalidRepairTypeException()
        {
        }

        public InvalidRepairTypeException(string message) : base(message)
        {
        }

        public InvalidRepairTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidRepairTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
