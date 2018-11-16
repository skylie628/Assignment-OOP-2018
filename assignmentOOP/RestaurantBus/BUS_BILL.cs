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
    public class BUS_BILL
    {
            SQL_Bill sql = new SQL_Bill();
            public void AddBill(EC_Bill et)
            {
            sql.AddBill(et);
            }
            public void UpdateBill(EC_Bill et)
            {
                sql.UpdateBill(et);
            }
            public void DeleteBill(EC_Bill et)
            {
            sql.DeleteBill(et);
            }
            public DataTable CreateData(string DieuKien)
            {
            return sql.CreateData(DieuKien);
            }
    }
}
