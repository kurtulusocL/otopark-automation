using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class CarBrand : BaseHome
    {        
        [StringLength(70)]
        public string Name { get; set; }

        public ICollection<Serial> Serials { get; set; }
        public ICollection<CarParkInfo> CarParkInfoes { get; set; }
    }
}
