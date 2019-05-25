using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class PhieuKham_BUS
    {
        public void NhapThongTinPhieuKhamMoi(PhieuKham_DTO pk)
        {
            pk.Insert();
        }

        public void XoaPhieuKham(PhieuKham_DTO pk)
        {
            pk.Delete();
        }

        public void SuaThongTinPhieuKham(PhieuKham_DTO pk)
        {
            pk.Update();
        }
    }
}
