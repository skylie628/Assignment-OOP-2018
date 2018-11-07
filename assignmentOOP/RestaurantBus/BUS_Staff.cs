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
    public class BUS_Staff
    {
        SQL_Staff sql = new SQL_Staff();
        public void AddStaff(EC_Staff et)
        {
            sql.AddStaff(et);
        }
        public void UpdateStaff(EC_Staff et)
        {
            sql.UpdateStaff(et);
        }
        public void DeleteStaff(EC_Staff et)
        {
            sql.DeleteStaff(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
        public string GetValue(String condition,int i)
        {
            return sql.GetValue(condition, i);
        }
    }
}
