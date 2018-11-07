using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;

namespace RestaurantDAL
{
   public class SQL_Customer
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddCustomer( EC_Customer et )
        {
            cn.ImplementSQL(@"INSERT INTO CUSTOMER (ID_CUSTOMER, Name, DateOfBirth, Sex, PhoneNumber) VALUES(N'" + et.Id + "',N'" + et.Name + "',N'" + et.DOB + "',N'" + et.Sex + "',N'" + et.Phone + "')");
        }
        public void UpdateCustomer(EC_Customer et)
        {
            cn.ImplementSQL(@"UPDATE CUSTOMER Set Name =N'" + et.Name + "', DateOfBirth =N'" + et.DOB + "', Sex =N'" + et.Sex+"', PhoneNumber ="+et.Phone+ " where ID_CUSTOMER=N'" +et.Id+"'");
        }
        public void DeleteCustomer(EC_Customer et)
        {
            cn.ImplementSQL(@"DELETE FROM CUSTOMER Where ID_CUSTOMER=N'" + et.Id+"'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from CUSTOMER " + DieuKien);
        }
    }
}
