﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Share.Models
{
    public enum Phanloai
    {
        [Display(Name = "Món")]
        Monan = 1,
        [Display(Name = "Combo")]
        Combo = 2,
        [Display(Name = "Nước")]
        Nuoc = 3,
    }

    public class MonAn
    {
        /*
        a.Mã số MonAnID int
        b.Tên món ăn Name nvarchar 250 Not null
        c.Mô tả (ngắn gọn) Des nvarchar 250 null
        d.Giá thành Price money not null
        e.Phân loại: Type món ăn hay combo
        Sử dụng enum
        f.	Hình ảnh minh họa nvarchar 150 null
        g.Trạng thái Status
        */

        [Key]
        public int MonAnID { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Bạn cần nhập tên.")]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập giá."), Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Giá")]
        public double Gia { get; set; }

        [Display(Name = "Phân loại")]
        [Required(ErrorMessage = "Bạn cần chọn phân loại."), Range(1, int.MaxValue, ErrorMessage = "Bạn cần chọn phân loại.")]
        public Phanloai Phanloai { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình")]
        public string Hinh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn hình")]
        public IBrowserFile ImageFile { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [Display(Name = "Đang phục vụ")]
        public bool Trangthai { get; set; }
    }
}
