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
        private string _IdMember;
        private Double _TotalPrice;
        public string Id { get => _Id; set => _Id = value; }
        public string Food { get => _Food; set => _Food = value; }
        public string DateBill { get => _DateBill; set => _DateBill = value; }
        public string IdTable { get => _IdTable; set => _IdTable = value; }
        public string Status { get => _Status; set => _Status = value; }
        public string IdMember { get => _IdMember; set => _IdMember = value; }
        public double TotalPrice { get => _TotalPrice; set => _TotalPrice = value; }
    }
}
