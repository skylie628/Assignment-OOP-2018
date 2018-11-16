using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Data;
namespace RestaurantDAL
{
    public class SQL_BillInfo
    {
        KetNoiDB cn = new KetNoiDB();
        public void AddBill(EC_BillInfo et)
        {
            cn.ImplementSQL(@"INSERT INTO BillInfo (ID,IDBill, IDFood, COUNT, Note) VALUES(N'" +et.Id+"',N'"+ et.IdBill + "', N'" + et.IdFood + "',N'" + et.Count + "',N'" + et.Note + "')");
        }
        public void UpdateBill(EC_BillInfo et)
        {
            cn.ImplementSQL(@"UPDATE BILLInfo SET IDBill =N'" + et.IdBill + "', IDFood =N'" + et.IdFood + "', COUNT =N'" + et.Count + "' where ID=N'" + et.Id + "'");
        }
        public void DeleteBill(EC_BillInfo et)
        {
            cn.ImplementSQL(@"DELETE FROM BILLInfo Where ID=N'" + et.Id + "'");
        }
        public DataTable CreateData(string DieuKien)
        {
            return cn.GetDataTable("Select * from BILLInfo " + DieuKien);
        }
        public string GetValue(String condition, int i)
        {
            return cn.GetValue("Select * from BILLInfo " + condition, i);
        }
    }
}
