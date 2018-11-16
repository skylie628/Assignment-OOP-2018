using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
   public class SQL_Food
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddFood(EC_Food et)
        {
            cn.ImplementSQL(@"INSERT INTO FOOD (ID, Name, PRICE, ID_CATEGORY) VALUES(N'" + et.Id + "', N'" + et.Name + "',N'" + et.Price + "',N'" + et.Cate + "')");
        }
        public void UpdateFood(EC_Food et)
        {
            cn.ImplementSQL(@"UPDATE FOOD SET Name =N'"+et.Name+"', PRICE =N'"+et.Price+"', ID_CATEGORY =N'"+et.Cate+"' where ID=N'"+et.Id+"'");
        }
        public void DeleteFood(EC_Food et)
        {
            cn.ImplementSQL(@"DELETE FROM FOOD Where Id=N'" +et.Id+"'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from FOOD " + DieuKien);
        }
        public string GetValue(String condition, int i)
        {
            return cn.GetValue("Select * from FOOD " + condition, i);
        }
    }
}
