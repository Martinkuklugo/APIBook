using WebApi.Models.Base;

namespace WebApi.Models;

public class Usuario: Model
{
    public string? Nombre {get; set;}

    public string? Apellido {get; set;}
    
    public string? telefono {get;set;}

    public string? direccion {get;set;}

    public string? Correo {get;set;}

    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;
    
        
}