using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace RestaurantDAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;
        public void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection("Data Source = DESKTOP-Q9KMPT9; Database = DATA; Integrated Security = True ");
            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();

        }
        public void Dongketnoi()
        {
            if(KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }
        }
        public void ImplementSQL(string strCon)
        {
            try
            { 
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strCon, connect);
            int ret = sqlcmd.ExecuteNonQuery();
            Dongketnoi();
             }
            catch{
            }
        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                Dongketnoi();
                return dt;
                
            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL,int i)
        { 
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read()) temp = sqldr[i].ToString();
            Dongketnoi(); 
            return temp; 
        }
    }
}
