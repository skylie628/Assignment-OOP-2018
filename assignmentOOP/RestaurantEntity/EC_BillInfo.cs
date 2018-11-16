using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_BillInfo
    {
        private string _Id;
        private string _IdBill;
        private string _IdFood;
        private int _count;
        private string _note;

        public string IdBill { get => _IdBill; set => _IdBill = value; }
        public string IdFood { get => _IdFood; set => _IdFood = value; }
        public int Count { get => _count; set => _count = value; }
        public string Note { get => _note; set => _note = value; }
        public string Id { get => _Id; set => _Id = value; }
    }
}
