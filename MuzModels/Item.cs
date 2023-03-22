using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Item
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemType { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? ShipmentId { get; set; }

    public int? Quantity { get; set; }

    public int? Space { get; set; }

    public virtual ICollection<Dispatch> Dispatches { get; } = new List<Dispatch>();

    public virtual Shipment? Shipment { get; set; }
}
