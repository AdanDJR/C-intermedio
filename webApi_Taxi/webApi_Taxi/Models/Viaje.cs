using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class Viaje
{
    public int Id { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Desde { get; set; }

    public string? Hasta { get; set; }

    public int? Calificacion { get; set; }

    public virtual ICollection<DetalleViaje> DetalleViajes { get; set; } = new List<DetalleViaje>();
}
