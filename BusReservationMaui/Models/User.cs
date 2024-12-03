namespace BusReservationMaui.Models;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int ClienteId { get; set; } 

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener m�s de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El apellido es obligatorio")]
    [StringLength(50, ErrorMessage = "El apellido no puede tener m�s de 50 caracteres")]
    public string Apellido { get; set; } = string.Empty;

    [Required(ErrorMessage = "El email es obligatorio")]
    [EmailAddress(ErrorMessage = "Debe ser un email v�lido")]
    public string Email { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Debe ser un n�mero de tel�fono v�lido")]
    public string Telefono { get; set; } = string.Empty;
    public string Ciudad { get; set; } = string.Empty;



    public ICollection<Reserva>? Reservas { get; set; } = new List<Reserva>();
}
