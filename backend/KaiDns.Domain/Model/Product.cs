using System;
using System.Collections.Generic;

namespace KaiDns.Domain.Model;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? CatalogId { get; set; }

    public decimal? Price { get; set; }

    public string? PathToImg { get; set; }

    public string? ProductInfo { get; set; }

    public virtual Catalog? Catalog { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
