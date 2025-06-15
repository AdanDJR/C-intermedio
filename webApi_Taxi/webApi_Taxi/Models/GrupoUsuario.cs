using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class GrupoUsuario
{
    public int Id { get; set; }

    public virtual ICollection<GrupoUsuariosDetalle> GrupoUsuariosDetalles { get; set; } = new List<GrupoUsuariosDetalle>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
