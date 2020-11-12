using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeDuyHieu_1721050702
{
    public partial class TrangChu : System.Web.UI.Page
    {
        cls_Connect cls_con = new cls_Connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_SV.Text = ((int)executeQuery("select count(MaSV) from tbl_sinhvien")).ToString();
            lbl_GV.Text = ((int)executeQuery("select count(MaGV) from tbl_giangvien")).ToString();
            lbl_DA.Text = ((int)executeQuery("select count(MaSV) from tbl_doan")).ToString();
            lbl_CN.Text = ((int)executeQuery("select count(MaCN) from tbl_chuyennganh")).ToString();

            lbl_SoSV_Mo.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 1")).ToString();
            lbl_SoSV_TracDia.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 2")).ToString();
            lbl_SoSV_KinhTe.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 3")).ToString();
            lbl_SoSV_DiaChat.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 4")).ToString();
            lbl_SoSV_MMT.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 5")).ToString();
            lbl_SoSV_CNPM.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 6")).ToString();
            lbl_SoSV_KHMT.Text = ((int)executeQuery("SELECT COUNT(MaSV) FROM dbo.tbl_sinhvien WHERE ChuyenNganh = 7")).ToString();

            Label0.Text = ((int)executeQuery("SELECT COUNT(Diem) FROM dbo.tbl_doan WHERE Diem < 7.0;")).ToString();
            Label1.Text = ((int)executeQuery("SELECT COUNT(Diem) FROM dbo.tbl_doan WHERE Diem > 7.1 and Diem <8.0;")).ToString();
            Label2.Text = ((int)executeQuery("SELECT COUNT(Diem) FROM dbo.tbl_doan WHERE Diem > 8.1 and Diem <9.0;")).ToString();
            Label3.Text = ((int)executeQuery("SELECT COUNT(Diem) FROM dbo.tbl_doan WHERE Diem > 9.1 and Diem <10.0;")).ToString();
        }
        private object executeQuery(String sql)
        {
            cls_con.conect_Data();
            String st_sql = sql;
            SqlCommand command = new SqlCommand();
            command.Connection = cls_con.con;
            command.CommandType = CommandType.Text;
            command.CommandText = st_sql;
            return command.ExecuteScalar();
        }
    }
}