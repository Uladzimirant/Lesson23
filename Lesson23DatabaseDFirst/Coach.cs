using System;
using System.Collections.Generic;

namespace Lesson23DatabaseDFirst;

public partial class Coach
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Surname { get; set; }

    public virtual ICollection<Team> Teams { get; } = new List<Team>();
}
