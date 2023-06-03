using System;
using System.Collections.Generic;

namespace WebApi.Data.Models;

public partial class BoughtProduct
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
