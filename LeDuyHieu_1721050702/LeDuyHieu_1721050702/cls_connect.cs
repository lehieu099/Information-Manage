using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LeDuyHieu_1721050702
{
    public class cls_connect
    {
        public string s_con = WebConfigurationManager.ConnectionStrings["connec_DATN"].ToString();
        public SqlConnection con;

        public void connect_Data()
        {
            if (con == null) con = new SqlConnection(s_con);
            if (con.State == ConnectionState.Closed) con.Open();
        }
        public void close_Data()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}