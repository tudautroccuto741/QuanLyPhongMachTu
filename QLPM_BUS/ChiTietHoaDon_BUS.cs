using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class ChiTietHoaDon_BUS
    {
        public void NhapThongTinChiTietHoaDonMoi(ChiTietHoaDon_DTO cthd)
        {
            cthd.Insert();
        }

        public void XoaChiTietHoaDon(ChiTietHoaDon_DTO cthd)
        {
            cthd.Delete();
        }

        public void SuaThongTinChiTietHoaDon(ChiTietHoaDon_DTO cthd)
        {
        }
    }
}
