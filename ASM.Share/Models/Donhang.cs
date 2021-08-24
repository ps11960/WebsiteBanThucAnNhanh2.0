//using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Share.Models
{
    public enum TrangthaiDonhang
    {
        [Display(Name = "Mới đặt")]
        Moidat = 1,
        [Display(Name = "Đang giao")]
        Danggiao = 2,
        [Display(Name = "Đã giao")]
        Dagiao = 3
    }

    public class Donhang
    {
        /*
       a.	Mã số
b.	Ngày đặt
c.	Trạng thái: mới đặt, đã giao
d.	Tổng số tiền
e.	Ghi chú
f.	Mã khách hàng
        */

        [Key]
        public int DonhangID { get; set;}

        [ForeignKey("Khachhang")]
        public int KhachhangID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Bạn cần chọn ngày."), Display(Name="Ngày đặt")]
        public DateTime Ngaydat { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Tổng tiền")]
        public double Tongtien { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangthaiDonhang TrangthaiDonhang { get; set; }

        [StringLength(250)]
        [Display(Name = "Ghi chú")]
        public string Ghichu { get; set; }
        
        public Khachhang Khachhang { get; set; }
        public List<DonhangChitiet> DonhangChitiets { get; set; }
    }
}
