using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Chucnang3
{
    class XLDL
    {
        public static string con = "Data Source=admin;Initial Catalog=QLBanSach;Integrated Security=True";
        public static DataTable GetData(string lenh)
        {   
            SqlConnection sqlcon = new SqlConnection(con);
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(lenh, sqlcon);
                DataTable dt = new DataTable();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
