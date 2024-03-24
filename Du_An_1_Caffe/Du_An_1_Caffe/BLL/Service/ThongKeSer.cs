
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class ThongKeSer
    {
        ThongKeRep _rep = new ThongKeRep();

        public List<SanPham> GetAllSP()
        {
            return _rep.GetAllSanPham();
        }
    }
}
