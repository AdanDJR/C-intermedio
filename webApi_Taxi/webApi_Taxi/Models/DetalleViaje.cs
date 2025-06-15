using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class DetalleViaje
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int ViajeId { get; set; }

    public virtual Viaje Viaje { get; set; } = null!;
}
