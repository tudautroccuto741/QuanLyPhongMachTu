using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class DonVi_BUS
    {
        public void NhapThongTinDonViMoi(DonVi_DTO dv)
        {
            dv.Insert();
        }

        public void XoaDonVi(DonVi_DTO dv)
        {
            dv.Delete();
        }

        public void SuaThongTinDonVi(DonVi_DTO dv)
        {
            dv.Update();
        }
    }
}
