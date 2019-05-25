using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class NhanSu_BUS
    {
        public void NhapThongTinNhanSuMoi(NhanSu_DTO ns)
        {
            ns.Insert();
        }

        public void XoaNhanSu(NhanSu_DTO ns)
        {
            ns.Delete();
        }

        public void SuaThongTinNhanSu(NhanSu_DTO ns)
        {
            ns.Update();
        }
    }
}
