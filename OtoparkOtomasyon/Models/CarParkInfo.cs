﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class CarParkInfo:BaseHome
    {
        [Display(Name ="Adı-Soyadı")]
        public string NameSurname { get; set; }

        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Plaka")]
        public string Plaka { get; set; }

        [Display(Name = "Yıl")]
        public string Year { get; set; }

        [Display(Name = "Renk")]
        public string Color { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public int CustomerId { get; set; }
        public int CarBrandId { get; set; }
        public int SerialId { get; set; }
        public int CarParkId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CarBrand CarBrand { get; set; }
        public virtual Serial Serial { get; set; }
        public virtual CarPark CarPark { get; set; }
    }
}
