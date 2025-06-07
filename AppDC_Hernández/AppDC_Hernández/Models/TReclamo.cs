using System;
using System.Collections.Generic;

namespace AppDC_Hernández.Models;

public partial class TReclamo
{
    public int IdReclamo { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string DireccionProveedor { get; set; } = null!;

    public string NombresConsumidor { get; set; } = null!;

    public string ApellidosConsumidor { get; set; } = null!;

    public string Dui { get; set; } = null!;

    public string DettalleReclamo { get; set; } = null!;

    public decimal? MontoReclamado { get; set; }

    public string? Telefono { get; set; }

    public DateTime FechaIngrese { get; set; }
}
