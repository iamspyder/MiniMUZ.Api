using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public virtual ICollection<UserWarehouse> UserWarehouses { get; } = new List<UserWarehouse>();
}
