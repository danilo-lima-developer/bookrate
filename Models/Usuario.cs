using System.ComponentModel.DataAnnotations;

namespace BookRate.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
    }
}
