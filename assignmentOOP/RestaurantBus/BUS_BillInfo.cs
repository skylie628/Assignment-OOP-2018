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
    public class BUS_BillInfo
    {
        SQL_BillInfo sql = new SQL_BillInfo();
        public void AddBill(EC_BillInfo et)
        {
            sql.AddBill(et);
            }
        public void UpdateBill(EC_BillInfo et)
        {
            sql.UpdateBill(et);
        }
        public void DeleteBill(EC_BillInfo et)
        {
            sql.DeleteBill(et);
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
