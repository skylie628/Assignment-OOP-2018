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
    public class BUS_Login
    {
        SQLLogin sql = new SQLLogin();
        public bool Check_Manager(string username,string password)
        {
            DataTable kq = sql.CreateDataMA(username, password);
            if (kq.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool Check_Staff(string username, string password)
        {
            DataTable kq = sql.CreateDataST(username, password);
            if (kq.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
