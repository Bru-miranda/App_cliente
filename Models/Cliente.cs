using System.ComponentModel.DataAnnotations;

namespace App_cliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MinLength (5)]
        public string? Name { get; set; }
        public int Contacto { get; set; }

        public string? Email { get; set; }
    }
}
