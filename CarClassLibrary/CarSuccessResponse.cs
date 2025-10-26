using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class CarSuccessResponse
    {
        public bool IsSuccess { get; set; }
        public string PtsNumber { get; set; }
        public Car Car { get; set; }
    }
}
