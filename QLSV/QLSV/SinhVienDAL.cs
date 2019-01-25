using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SinhVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SinhVienDAL ()
        {
            dc = new DataConnection();
        }
        public DataTable getAllSinhVien()
        {
            //tao cau lenh lay ra toan bo sinh vien
            string sql = "SELECT * FROM SinhVien";
            //TAO 1 KET NOI DEN SQL
            SqlConnection con = dc.getConnect();
            //khoi tao 1 doi tuong lop DataAdapter
            da = new SqlDataAdapter(sql, con);
            //mo ket noi
            con.Open();
            //lay du lieu tu DataAdapter vao DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dong ket noi
            con.Close();
            return dt;
        }
        public bool InsertSinhVien(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSVV, TenSVV, NamSinhh, DiaChii) VALUES(@MaSVV, @TenSVV, @NamSinhh, @DiaChii)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSVV",SqlDbType.NVarChar).Value =sv.MaSVV;
                cmd.Parameters.Add("@TenSVV",SqlDbType.NVarChar).Value =sv.TenSVV;
                cmd.Parameters.Add("@NamSinhh",SqlDbType.Int).Value =sv.NamSinhh;
                cmd.Parameters.Add("@DiaChii", SqlDbType.NVarChar).Value = sv.DiaChii;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpDateSinhVien(SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET MaSVV= @MaSVV, TenSVV=@TenSVV, NamSinhh=@NamSinhh, DiaChii=@DiaChii WHERE Idd=@Idd";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Idd", SqlDbType.Int).Value = sv.Idd;
                cmd.Parameters.Add("@MaSVV", SqlDbType.NVarChar).Value = sv.MaSVV;
                cmd.Parameters.Add("@TenSVV", SqlDbType.NVarChar).Value = sv.TenSVV;
                cmd.Parameters.Add("@NamSinhh", SqlDbType.Int).Value = sv.NamSinhh;
                cmd.Parameters.Add("@DiaChii", SqlDbType.NVarChar).Value = sv.DiaChii;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            string sql = "DELETE SinhVien WHERE Idd = @Idd";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Idd", SqlDbType.Int).Value = sv.Idd;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
    }

