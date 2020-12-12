using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_igor_gladson.Models
{
    public class Car
    {
        [Key]
        public int IDCar { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Informe a Marca.")]
        [DisplayName("Marca")]
        public string Mark { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Informe o Modelo.")]
        [DisplayName("Modelo")]
        public string Model { get; set; }


        [Column(TypeName = "varchar(4)")]
        [Required(ErrorMessage = "Informe o ano.")]
        [DisplayName("Ano")]
        public string Year { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Informe o preço.")]
        [DisplayName("Preço")]
        public string Price { get; set; }

    }
}
