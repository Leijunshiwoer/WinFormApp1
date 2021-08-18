using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class SqlHelper
    {
        private static SqlConnection GetConn()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString);
        }

        // 执行sql操作   返回是否存在用户
        public static bool IsUserExists(string uId)
        {
            bool isExists = false;

            using (SqlConnection conn = GetConn())
            {
                string sql = "select count(*) from users where uId =@uId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@uId", uId));
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }
    }
}
