using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
    public class SQL_FoodCate
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddFoodCate(EC_FoodCategory et)
        { 
            cn.ImplementSQL("insert into FOODCATEGORY (ID, Name) values(N'"+et.Id+"',N'"+et.Name+"')");
            
        }
        public void UpdateFoodCate(EC_FoodCategory et)
        {
            cn.ImplementSQL("UPDATE FOODCATEGORY SET Name =N'"+et.Name+"'where ID=N'"+et.Id+"'");
        }
        public void DeleteFoodCate(EC_FoodCategory et)
        {
            cn.ImplementSQL(@"DELETE FROM FOODCATEGORY Where Id=N'" + et.Id+"'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from FOODCATEGORY " + DieuKien);
        }
        public string GetValue(string condition,int i)
        {
            return cn.GetValue("Select * from FOODCATEGORY " + condition,i);
        }
    }
}
