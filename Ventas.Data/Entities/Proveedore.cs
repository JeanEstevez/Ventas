namespace Ventas.Data.Entities;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string Email { get; set; } = null!;

    public string? Contacto { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
