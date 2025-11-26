using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_điểm_học_sinh
{
     public class HOCSINH
    {
        public string HoTen { get; set; }
        public double DiemVan { get; set; }
        public double DiemToan { get; set; }

        public HOCSINH(string HT, double DV, double DT)
        {
            HoTen = HT;
            DiemVan = DV;
            DiemToan = DT;
        }

        public double TinhDiemTB()
        {
            return Math.Round((DiemVan + DiemToan) / 2, 2);
        }


    }
}
