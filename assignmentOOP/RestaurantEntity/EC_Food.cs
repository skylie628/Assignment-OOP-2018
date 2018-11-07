using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class EC_Food
    {
        private string _Id;
        private string _Name;
        private float _Price;
        private string _Cate;
        public string Name { get => _Name; set => _Name = value; }
        public string Id { get => _Id; set => _Id = value; }
        public float Price { get => _Price; set => _Price = value; }
        public string Cate { get => _Cate; set => _Cate = value; }
    }

}
