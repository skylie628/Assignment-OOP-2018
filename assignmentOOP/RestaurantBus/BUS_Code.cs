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
    public class BUS_Code
    {
        SQL_Code sql = new SQL_Code();
        public void AddCode(EC_CODE et)
        {
            sql.AddCode(et);
        }
        public void UpdateCode(EC_CODE et)
        {
            sql.UpdateCode(et);
        }
        public void DeleteCode(EC_CODE et)
        {
            sql.DeleteCode(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
        public string GetValue(String condition, int i)
        {
            return sql.GetValue(condition, i);
        }
    }
}
