
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.DAL.Repstory
{
    public class ThongKeRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        public List<SanPham> GetAllSanPham()
        {
            return db.SanPhams.ToList();
        }


    }
}
