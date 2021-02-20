using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class Customer:BaseHome
    {
        [Display(Name ="Adı-Soyadı")]
        public string NameSurname { get; set; }

        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adresi")]
        public string Adress { get; set; }

        [Display(Name = "E-Mail")]
        public string EMail { get; set; }

        [Display(Name = "Resim")]
        public string Photo { get; set; }

        public ICollection<CarParkInfo> CarParkInfoes { get; set; }
    }
}
