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
    public class BUS_Account
    {
        SQL_Account sql = new SQL_Account();
        public void AddAccount(EC_Account et)
        {
            sql.AddAccount(et);
        }
        public void UpdateAccount(EC_Account et)
        {
            sql.UpdateAccount(et);
         }
        public void DeleteAccount(EC_BillInfo et)
        {
            sql.DeleteAccount(et);
            }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
    }
}
