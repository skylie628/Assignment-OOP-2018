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
    public class BUS_TableFood
    {
        SQL_TableFood sql = new SQL_TableFood();
        public void AddTableFood(EC_TableFood et)
        {
            sql.AddTableFood(et);
        }
        public void DeleteTableFood(EC_TableFood et)
        {
            sql.DeleteTableFood(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
    }
}
