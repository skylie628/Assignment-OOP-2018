using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;

namespace RestaurantDAL
{
    public class SQL_TableFood
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddTableFood(EC_TableFood et)
        {
            cn.ImplementSQL("insert into TABLEFOOD (ID) values(N'" + et.Id+"')");

        }
        public void DeleteTableFood(EC_TableFood et)
        {
            cn.ImplementSQL(@"DELETE FROM TABLEFOOD Where ID=N'" + et.Id + "'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from TABLEFOOD " + DieuKien);
        }
    }
}
