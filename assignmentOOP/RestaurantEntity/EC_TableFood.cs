using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_TableFood
    {
       private string _Id;
       private string _Name;

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
