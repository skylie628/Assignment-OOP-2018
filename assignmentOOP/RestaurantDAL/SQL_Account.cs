using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
    public class SQL_Account
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddAccount(EC_Account et)
        {
            cn.ImplementSQL(@"INSERT INTO ACCOUNT (ID,UserName, Password, TYPE) VALUES(N'" + et.Id + "',N'" + et.UserName + "', N'" + et.Password + "',N'" + et.Type + "'");
        }
        public void UpdateAccount(EC_Account et)
        {
            cn.ImplementSQL(@"UPDATE ACCOUNT SET UserName =N'" + et.UserName + "', Password =N'" + et.Password + "', TYPE =N'" + et.Type + "' where ID=N'" + et.Id + "'");
        }
        public void DeleteAccount(EC_BillInfo et)
        {
            cn.ImplementSQL(@"DELETE FROM ACCOUNT Where ID=N'" + et.Id + "'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from ACCOUNT " + DieuKien);
        }

    }
}
