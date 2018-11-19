using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_CODE
    {
        string _ID;
        string _NameCode;
        int _Amount;
        int _Status;

        public string ID { get => _ID; set => _ID = value; }
        public string NameCode { get => _NameCode; set => _NameCode = value; }
        public int Amount { get => _Amount; set => _Amount = value; }
        public int Status { get => _Status; set => _Status = value; }
    }
}
