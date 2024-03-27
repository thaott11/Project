using DuAn1_Coffe.DAL.Models;
using DuAn1_Coffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class GiamGiaSer
    {
        GiamGiaRep  GiamGiaRepositori = new GiamGiaRep();
        public List<GiamGium> AllGiamGia()
        {
            return GiamGiaRepositori.Getgiamgia();
        }

        public string Them(GiamGium giamGium)
        {
            if (GiamGiaRepositori.GetThem(giamGium))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string Sua(int? id, GiamGium giamGium)
        {
            if (GiamGiaRepositori.GetThem(giamGium))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<GiamGium> TimkiemMa(string ma)
        {
            return GiamGiaRepositori.FindMa(ma);
        }
    }
}
