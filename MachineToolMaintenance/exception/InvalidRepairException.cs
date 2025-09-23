using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.exception
{
    public class InvalidRepairException : Exception
    {
        public InvalidRepairException()
        {
        }

        public InvalidRepairException(string message) : base(message)
        {
        }

        public InvalidRepairException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidRepairException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
