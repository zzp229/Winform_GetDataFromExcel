using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using System.Data;


namespace DAL
{
    public class StudentClassService
    {
        public List<StudentClass> GetAllClass(string path)
        {
            string sql = "select * from [Sheet1$]";
            DataSet ds = OleDbHelper.GetDataSet(sql, path);
            List<StudentClass> list = new List<StudentClass>();
            DataTable dt = ds.Tables[0];

            foreach( DataRow dr in dt.Rows ){
                list.Add(new StudentClass
                {
                    ClassId = Convert.ToInt32(dr["ClassId"]),
                    ClassName = Convert.ToString(dr["ClassName"])
                });
            }

            return list;
        }
    }
}
