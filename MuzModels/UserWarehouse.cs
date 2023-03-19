using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class UserWarehouse
{
    public int Uwid { get; set; }

    public int? UserId { get; set; }

    public int? WarehouseId { get; set; }

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();

    public virtual User? User { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
