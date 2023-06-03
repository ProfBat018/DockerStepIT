using System;
using System.Collections.Generic;

namespace WebApi.Data.Models;

public partial class Receipt
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Total { get; set; }

    public int? BoughtProductsId { get; set; }

    public virtual BoughtProduct? BoughtProducts { get; set; }
}
