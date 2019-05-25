using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class ToaThuoc_BUS
    {
        public void NhapThongTinToaThuocMoi(ToaThuoc_DTO tt)
        {
            tt.Insert();
        }

        public void XoaToaThuoc(ToaThuoc_DTO tt)
        {
            tt.Delete();
        }

        public void SuaThongTinToaThuoc(ToaThuoc_DTO tt)
        {
            tt.Update();
        }
    }
}
