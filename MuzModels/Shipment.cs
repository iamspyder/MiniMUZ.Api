using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public string? ShipmentName { get; set; }

    public int? Uwid { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public virtual ICollection<Dispatch> Dispatches { get; } = new List<Dispatch>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual UserWarehouse? Uw { get; set; }
}
