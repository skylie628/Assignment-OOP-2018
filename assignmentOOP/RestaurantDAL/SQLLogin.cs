using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;

namespace RestaurantDAL
{
    public class SQLLogin
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable CreateDataMA(string username, string password)
        {
            return cn.GetDataTable("SELECT * FROM MANAGER WHERE UserName='" + username + "' AND Password = '" + password + "'");
        }
        public DataTable CreateDataST(string username, string password)
        {
            return cn.GetDataTable("SELECT * FROM STAFF WHERE UserName='" + username + "' AND Password = '" + password + "'");
        }
    }
}
