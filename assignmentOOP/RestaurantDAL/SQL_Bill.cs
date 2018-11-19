using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
    public class SQL_Bill
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddBill(EC_Bill et)
        {
            cn.ImplementSQL(@"INSERT INTO Bill (ID, DateBill, IDTable, Status) VALUES(N'" + et.Id + "', N'" + et.DateBill + "',N'" + et.IdTable + "',N'" + et.Status + "')");
        }
        public void UpdateBill(EC_Bill et)
        {
            cn.ImplementSQL(@"UPDATE BILL SET DateBill = N'"+et.DateBill+"', IDTable = N'"+et.IdTable+"', Status= N'"+int.Parse(et.Status)+"', IDMember =N'"+ et.IdMember+"', TotalPrice =N'"+et.TotalPrice+"' where ID=N'"+et.Id+"'");
        }
        public void DeleteBill(EC_Bill et)
        {
            cn.ImplementSQL(@"DELETE FROM BILL Where ID=N'" + et.Id + "'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from BILL " + DieuKien);
        }

    }
}
