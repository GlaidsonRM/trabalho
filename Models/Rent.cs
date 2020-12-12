using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_igor_gladson.Models
{
    public class Rent
    {
        [Key]
        public int IDRent { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Informe seu nome")]
        [DisplayName("Seu nome")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Informe o seu email")]
        [DisplayName("Seu E-mail")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(11)")]
        [Required(ErrorMessage = "Informe o seu telefone")]
        [DisplayName("seu telefone")]
        public string Phone { get; set; }
    }
}
