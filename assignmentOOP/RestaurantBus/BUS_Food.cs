using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestaurantDAL;
using RestaurantEntity;

namespace RestaurantBus
{
    public class BUS_Food
    {
        SQL_Food sql = new SQL_Food();
        public void AddFood(EC_Food et)
        {
            sql.AddFood(et);
        }
        public void UpdateFood(EC_Food et)
        {
            sql.UpdateFood(et);
          }
        public void DeleteFood(EC_Food et)
        {
            sql.DeleteFood(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
    }
}
