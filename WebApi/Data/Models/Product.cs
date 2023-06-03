using System;
using System.Collections.Generic;

namespace WebApi.Data.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public byte[]? Qrcode { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateTime? ExpirationTime { get; set; }

    public virtual ICollection<BoughtProduct> BoughtProducts { get; set; } = new List<BoughtProduct>();
}
