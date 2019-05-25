using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class Thuoc_BUS
    {
        public void NhapThongTinThuocMoi(Thuoc_DTO th)
        {
            th.Insert();
        }

        public void XoaThuoc(Thuoc_DTO th)
        {
            th.Delete();
        }

        public void SuaThongTinThuoc(Thuoc_DTO th)
        {
            th.Update();
        }
    }
}
