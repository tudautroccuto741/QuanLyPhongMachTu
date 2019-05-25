using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class BenhNhan_BUS
    {
        public void NhapThongTinBenhNhanMoi(BenhNhan_DTO bn)
        {
            bn.Insert();
        }

        public void XoaBenhNhan(BenhNhan_DTO bn)
        {
            bn.Delete();
        }

        public void SuaThongTinBenhNhan(BenhNhan_DTO bn)
        {
            bn.Update();
        }
    }
}
