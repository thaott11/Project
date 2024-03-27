using DuAn1_Coffe.DAL.Models;
using DuAn1_Coffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class HoaDonChiTietSer
    {
        HoaDonChiTietRep HoaDonchitietRepositori = new HoaDonChiTietRep();

        public List<HoaDonChiTiet> AllHoadonchitiet()
        {
            return HoaDonchitietRepositori.GetHoaDonchotiet();
        }
    }
}
