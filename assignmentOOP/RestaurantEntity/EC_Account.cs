using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
   public class EC_Account
    {
        private string _Id;
        private string _UserName;
        private string _Password;
        private int _Type;

        public string Id { get => _Id; set => _Id = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int Type { get => _Type; set => _Type = value; }
    }
}
