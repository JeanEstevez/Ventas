
namespace Ventas.Data.Entities;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Puesto { get; set; }

    public decimal? Salario { get; set; }

    public DateOnly FechaContratacion { get; set; }

    public string Email { get; set; } = null!;
}
