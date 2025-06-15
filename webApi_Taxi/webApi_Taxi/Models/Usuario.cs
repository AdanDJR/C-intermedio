using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Documento { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int? GrupoUsuariosId { get; set; }

    public virtual GrupoUsuario? GrupoUsuarios { get; set; }

    public virtual ICollection<GrupoUsuariosDetalle> GrupoUsuariosDetalles { get; set; } = new List<GrupoUsuariosDetalle>();
}
