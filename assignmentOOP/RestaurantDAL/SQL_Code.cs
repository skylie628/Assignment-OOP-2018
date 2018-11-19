using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
    public class SQL_Code
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddCode(EC_CODE et)
        {
            cn.ImplementSQL(@"INSERT INTO CODE (Id, NameCode, Amount, Status) VALUES(N'" + et.ID + "', N'" + et.NameCode + "',N'" + et.Amount + "',N'" + et.Status + "')");
        }
        public void UpdateCode(EC_CODE et)
        {
            cn.ImplementSQL(@"UPDATE CODE SET NameCode =N'" + et.NameCode + "', Amount =N'" + et.Amount + "', Status =N'" + et.Status + "' where Id=N'" + et.ID + "'");
        }
        public void DeleteCode(EC_CODE et)
        {
            cn.ImplementSQL(@"DELETE FROM CODE Where Id=N'" + et.ID + "'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from CODE " + DieuKien);
        }
        public string GetValue(String condition, int i)
        {
            return cn.GetValue("Select * from CODE " + condition, i);
        }
    }
}
