using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;

namespace RestaurantDAL
{
    public class SQL_Staff
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddStaff(EC_Staff et)
        {
            cn.ImplementSQL(@"INSERT INTO STAFF (ID, Name, DateOfBirth, Sex, UserName, Password, PhoneNumber) VALUES(N'" + et.Id + "',N'" + et.Name + "',N'" + et.DOB + "',N'" + et.Sex + "',N'" + et.UserName + "',N'" + et.Password + "',N'"+et.Phone+"')");
        }
        public void UpdateStaff(EC_Staff et)
        {
            cn.ImplementSQL("UPDATE STAFF  SET  Name =N'"+et.Name+"', DateOfBirth =N'"+et.DOB+"', Sex =N'"+et.Sex+"', PhoneNumber = "+et.Phone+" where ID=N'"+et.Id+"'");
        }
        public void DeleteStaff(EC_Staff et)
        {
            cn.ImplementSQL(@"DELETE FROM STAFF Where Id=N'" + et.Id+"'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from STAFF " + DieuKien);
        }
        public string GetValue(String condition,int i)
        {
            return cn.GetValue("Select * from STAFF " + condition,i);
        }
    }
}
