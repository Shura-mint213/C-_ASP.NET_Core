using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyComponyWebTestMVC.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните названия услуги")]
        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Кратное опиасние услуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
