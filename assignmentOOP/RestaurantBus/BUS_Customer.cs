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
    public class BUS_Customer
    {
        SQL_Customer sql = new SQL_Customer();
        public void AddCustomer(EC_Customer et)
        {
            sql.AddCustomer(et);
        }
        public void UpdateCustomer(EC_Customer et)
        {
            sql.UpdateCustomer(et);
        }
        public void DeleteCustomer(EC_Customer et)
        {
            sql.DeleteCustomer(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        }
    }
}
