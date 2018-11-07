using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_Customer
    {
        private string _Id;
        private string _Name;
        private string _DOB;
        private string _Sex;
        private string _phone;

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string DOB { get => _DOB; set => _DOB = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
