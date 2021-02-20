using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon.Models
{
    public class BaseHome
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public BaseHome()
        {
            CreatedDate = DateTime.Now.ToLocalTime();
            UpdatedTime = DateTime.Now.ToLocalTime();
        }
    }
}
