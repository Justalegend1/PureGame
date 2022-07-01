using System;
using System.ComponentModel.DataAnnotations;

namespace PureGame.Entity
{
    public class Player
    {
        [Key]
        public int id_player { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Введите фамилию")]
        public string Middle_name { get;set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        [Display(Name = "Отчество")]
        public string Father_name { get; set; }
        [Display(Name = "Название команды")]
        [Required(ErrorMessage = "Введите название команды")]
        public int id_team { get; set; }
        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Введите почту")]
        public string e_mail { get; set; }
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Введите дату рождения")]
        public DateTime Birth_date { get; set; }
    }
}
