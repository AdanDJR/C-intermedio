using System;
using System.Collections.Generic;

namespace webApi_Taxi.Models;

public partial class Taxi
{
    public int Id { get; set; }

    public string Placa { get; set; } = null!;
}
