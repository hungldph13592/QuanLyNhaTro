using _1_DAL_QLNT.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.IServices
{
    public interface IQuanLyDienNuoc
    {
        
        public List<DienNuoc> LoadDataLoaiDn();
        public string AddDV(DienNuoc dienNuoc);
        public string EditDV(DienNuoc dienNuoc);
    }
}
