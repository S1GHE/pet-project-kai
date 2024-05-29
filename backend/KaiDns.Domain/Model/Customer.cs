using System;
using System.Collections.Generic;

namespace KaiDns.Domain.Model;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? UserName { get; set; }

    public string? Passcode { get; set; }

    public bool? IsEnabled { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool? IsVerefication { get; set; }

    public string? HashVerefication { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
