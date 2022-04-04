using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTour.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Mã Tour")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Địa Điểm")]
        public string NameTour { get; set; }

        [Display(Name = "Ngày Xuất Phát")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Required]
        [Display(Name = "Điểm Đến")]
        public string Place { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        [Display(Name = "Giá Tiền")]
        public decimal Price { get; set; }

        [Display(Name = "Chú Thích")]
        public string Note { get; set; }
    }
}
