using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Datban
    {
        DAL_datban daDB = new DAL_datban();
        public DataTable getDB()
        {
            return daDB.getDB();
        }
        public bool insertDatban(string SoBan, string TenKhachHang, string Ngay, string SDT)
        {
            return daDB.insertDatban(SoBan, TenKhachHang, Ngay, SDT);
        }
        public bool updateDatban(int Maban, string SoBan, string TenKhachHang, string Ngay, string SDT)
        {
            return daDB.updateDatban(Maban, SoBan, TenKhachHang, Ngay, SDT);
        }
        public bool deleteDatban(int Maban)
        {
            return daDB.deleteDatban(Maban);
        }
        public bool seachDatban(string TenKhachHang)
        {
            return daDB.seachDatban(TenKhachHang);
        }
    }
}
