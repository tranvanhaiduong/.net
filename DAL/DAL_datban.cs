using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public  class  DAL_datban : DBConnection
    {
        public DataTable getDB()
        {
            SqlDataAdapter da = new SqlDataAdapter("select* from datban", con);
            DataTable daDB = new DataTable();
            da.Fill(daDB);
            daDB.Columns.Add("STT");
            for (int i = 1; i <= daDB.Rows.Count; i++)
                daDB.Rows[i - 1]["STT"] = i.ToString();
            return daDB;
        }
        public bool seachDatban(string TenKhachHang)
        {
            string str = string.Format("select TenKhachHang from datban",TenKhachHang);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool insertDatban(string SoBan, string TenKhachHang, string Ngay, string SDT)
        {
            string str = string.Format("insert into datban(SoBan,TenKhachHang,Ngay,SDT) values('{0}','{1}','{2}','{3}')", SoBan, TenKhachHang, Ngay, SDT);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool updateDatban(int Maban ,string SoBan, string TenKhachHang, string Ngay, string SDT)
        {
            string str = string.Format("update datban set Soban='{0}', TenKhachHang='{1}', Ngay='{2}', SDT='{3}' where Maban='{4}'",SoBan,TenKhachHang,Ngay,SDT,Maban);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool deleteDatban(int Maban)
        {
            string str = string.Format("delete from datban where Maban = '{0}'", Maban);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
