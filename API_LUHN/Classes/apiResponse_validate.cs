using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LUHN.Classes
{
    public class apiResponse_validate
    {
        public String LuhnNumberGiven { get; set; }
        public Boolean validation { get; set; }
        public DateTime timeStamp { get; set; }

    }
}
