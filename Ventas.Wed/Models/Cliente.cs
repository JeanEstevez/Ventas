
namespace Ventas.Web.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly FechaRegistro { get; set; }
}
