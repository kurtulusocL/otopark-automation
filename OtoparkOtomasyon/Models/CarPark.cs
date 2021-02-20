using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class CarPark : BaseHome
    {
        [Display(Name ="Park Yeri")]
        public string ParkArea { get; set; }

        [Display(Name = "Park Durumu")]
        public string State { get; set; }

        public ICollection<CarParkInfo> CarParkInfoes { get; set; }
    }
}
