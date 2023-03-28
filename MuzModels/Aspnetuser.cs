using System;
using System.Collections.Generic;

namespace MiniMUZ.Api.MuzModels;

public partial class Aspnetuser
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public byte EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public byte PhoneNumberConfirmed { get; set; }

    public byte TwoFactorEnabled { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public byte LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public DateTime CreatedOn { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public byte IsActive { get; set; }

    public virtual ICollection<Aspnetuserlogin> Aspnetuserlogins { get; } = new List<Aspnetuserlogin>();
}
