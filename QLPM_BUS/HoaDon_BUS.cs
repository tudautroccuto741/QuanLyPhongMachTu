using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class HoaDon_BUS
    {
        public void NhapThongTinHoaDonMoi(HoaDon_DTO hd)
        {
            hd.Insert();
        }

        public void XoaHoaDon(HoaDon_DTO hd)
        {
            hd.Delete();
        }

        public void SuaThongTinHoaDon(HoaDon_DTO hd)
        {
            hd.Update();
        }
    }
}
