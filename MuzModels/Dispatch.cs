using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Dispatch
{
    public int DispatchId { get; set; }

    public int? ShipmentId { get; set; }

    public int? VehicleId { get; set; }

    public string? DispatchDetails { get; set; }

    public DateTime? DispatchDate { get; set; }

    public virtual Shipment? Shipment { get; set; }

    public virtual Vehicle? Vehicle { get; set; }
}
