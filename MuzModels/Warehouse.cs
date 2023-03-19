using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public string? WareHouseLocation { get; set; }

    public virtual ICollection<UserWarehouse> UserWarehouses { get; } = new List<UserWarehouse>();
}
