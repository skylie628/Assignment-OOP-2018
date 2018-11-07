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
   public class BUS_FoodCate
    {
        SQL_FoodCate sql = new SQL_FoodCate();
        public void AddFoodCate(EC_FoodCategory et)
        {
            sql.AddFoodCate(et);
        }
        public void UpdateFoodCate(EC_FoodCategory et)
        {
            sql.UpdateFoodCate(et);
        }
        public void DeleteFoodCate(EC_FoodCategory et)
        {
            sql.DeleteFoodCate(et);
        }
        public DataTable CreateData(string DieuKien)
        {
            return sql.CreateData(DieuKien);
        } 
        public string GetValue(string condition,int i)
        {
            return sql.GetValue(condition,i);
        }
    }
}
