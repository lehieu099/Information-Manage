using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LeDuyHieu_1721050702
{
    public class cls_Connect
    {
        // lấy chuỗi kết nối trong web.config
        public string s_con = WebConfigurationManager.ConnectionStrings["connec_DATN"].ToString();
        public SqlConnection con;

        public void conect_Data() // thủ tục mở kết nối.
        {
            if(con == null) con = new SqlConnection(s_con);
            if (con.State == ConnectionState.Closed) con.Open();
        }
        public void closed_Data() //thu tuc dong ket noi
        {
            if(con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}