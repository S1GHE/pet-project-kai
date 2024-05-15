﻿using System;
using System.Collections.Generic;

namespace KaiDns.Domain.Model;

public partial class Catalog
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsEnabled { get; set; }

    public string? PathToIcon { get; set; }

    public int? ParentId { get; set; }

    public virtual ICollection<Catalog> InverseParent { get; set; } = new List<Catalog>();

    public virtual Catalog? Parent { get; set; }
}
