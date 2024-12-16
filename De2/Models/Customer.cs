using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace De2.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Nhap di")]
        public string Fullname { get; set; } = null!;
        [Required(ErrorMessage = "Nhap di")]

        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Nhap di")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Nhap di")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp. Thử lại")]
        public string RePassword { get; set; } = null!;

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
