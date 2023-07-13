using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class OleDbHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public static DataSet GetDataSet(string sql, string path)
        {
            //创建连接器
            OleDbConnection conn = new OleDbConnection(string.Format(connStr, path));   //因为这个要路径
            //创建命令器
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            //创建适配器
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);    //适配器是要通过命令器创建出来的
            //创建DataSet
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
