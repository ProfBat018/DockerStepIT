using System;
using System.Collections.Generic;

namespace WebApi.Data.Models;

public partial class Customer
{
    public int Id { get; set; }

    public int? BonusId { get; set; }

    public virtual BonusCard? Bonus { get; set; }
}
