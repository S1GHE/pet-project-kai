using System;
using System.Collections.Generic;

namespace KaiDns.Domain.Model;

public partial class Catalog
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsEnabled { get; set; }
}
