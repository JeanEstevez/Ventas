
namespace Ventas.Web.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? IdProveedor { get; set; }

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
