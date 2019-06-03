using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class CachDung_BUS
    {
        public void NhapThongTinCachDungMoi(CachDung_DTO cd)
        {
            cd.Insert();
        }

        public void XoaCachDung(CachDung_DTO cd)
        {
            cd.Delete();
        }

        public void SuaThongTinCachDung(CachDung_DTO cd)
        {
            cd.Update();
        }
    }
}
