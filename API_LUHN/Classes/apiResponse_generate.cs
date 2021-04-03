using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LUHN.Classes
{
    public class apiResponse_generate
    {
        public String generatedLuhnNumber { get; set; }
        public DateTime timeStamp { get; set; }
    }
}
