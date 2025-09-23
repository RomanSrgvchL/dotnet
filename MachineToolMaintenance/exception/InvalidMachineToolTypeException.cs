using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.exception
{
    public class InvalidMachineToolTypeException : Exception
    {
        public InvalidMachineToolTypeException()
        {
        }

        public InvalidMachineToolTypeException(string message) : base(message)
        {
        }

        public InvalidMachineToolTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidMachineToolTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
