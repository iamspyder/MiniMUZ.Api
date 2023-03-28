using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Aspnetrole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<Aspnetroleclaim> Aspnetroleclaims { get; } = new List<Aspnetroleclaim>();
}
