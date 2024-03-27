using DuAn1_Coffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class HoaDonChiTietRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();
        public List<HoaDonChiTiet> GetHoaDonchotiet()
        {
            return db.HoaDonChiTiets.ToList();
        }
    }
}
