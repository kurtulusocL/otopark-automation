using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class Serial:BaseHome
    {
        public string Seri { get; set; }

        public int CarBrandId { get; set; }
        public virtual CarBrand CarBrand { get; set; }

        public ICollection<CarParkInfo> CarParkInfoes { get; set; }
    }
}
