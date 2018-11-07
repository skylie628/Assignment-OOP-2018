using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_Staff
    {
        string _Id;
        string _Name;
        string _DOB;
        string _Sex;
        string _UserName;
        string _Password;
        string _phone;

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string DOB { get => _DOB; set => _DOB = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
