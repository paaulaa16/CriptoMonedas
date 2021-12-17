using System.ComponentModel.DataAnnotations;
namespace CriptoMonedas.Models
{

    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Ultimo { get; set; }
        public decimal Max { get; set; }
    }
}