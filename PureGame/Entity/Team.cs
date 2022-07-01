using System.ComponentModel.DataAnnotations;

namespace PureGame.Entity
{
    public class Team
    {
        [Key]
        public int id_team { get; set; }
        [Display(Name = "Название команды")]
        [Required(ErrorMessage = "Введите название команды")]
        public string team_name { get; set; }
        [Display(Name = "Количество игроков")]
        [Required(ErrorMessage = "Введите количество игроков")]
        public int players_count { get; set; }
        [Display(Name = "Количество очков")]
        [Required(ErrorMessage = "Введите количество очков")]
        public int points_count { get; set; }
    }
}
