using System.ComponentModel.DataAnnotations;

namespace BookRate.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "o campo CPF não pode ter mais de 11 caracteres")]
        public string Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
