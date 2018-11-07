using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_Bill
    {
        private string _Id;
        private string _Food;
        private string _DateBill;
        private string _IdTable;
        private string _Status;

        public string Id { get => _Id; set => _Id = value; }
        public string Food { get => _Food; set => _Food = value; }
        public string DateBill { get => _DateBill; set => _DateBill = value; }
        public string IdTable { get => _IdTable; set => _IdTable = value; }
        public string Status { get => _Status; set => _Status = value; }
    }
}
