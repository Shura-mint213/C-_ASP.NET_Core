using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShopCarMVC.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна имени не меньше 2 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна фамилии не меньше 2 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адресс")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длинна адресса не меньше 10 символов")]
        public string adress { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Введите тулефон")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна телефона не меньше 11 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите почту")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длинна имени не меньше 2 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
