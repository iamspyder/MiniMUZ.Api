using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? VehicleName { get; set; }

    public string? VehicleNo { get; set; }

    public string? OwnerName { get; set; }

    public virtual ICollection<Dispatch> Dispatches { get; } = new List<Dispatch>();
}
