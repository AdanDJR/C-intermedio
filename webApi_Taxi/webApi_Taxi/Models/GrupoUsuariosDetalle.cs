using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class GrupoUsuariosDetalle
{
    public int Id { get; set; }

    public int GrupoUsuariosId { get; set; }

    public int UsuarioId { get; set; }

    public virtual GrupoUsuario GrupoUsuarios { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
