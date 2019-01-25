using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SinhVienXL
    {
        SinhVienDAL dalSV;
        public SinhVienXL()
        {
            dalSV = new SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool InsertSinhVien(SinhVien sv)
        {
            return dalSV.InsertSinhVien(sv);
        }
        public bool UpDateSinhVien(SinhVien sv)
        {
            return dalSV.UpDateSinhVien(sv);
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }

    }
}
