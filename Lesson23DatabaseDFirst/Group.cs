using System;
using System.Collections.Generic;

namespace Lesson23DatabaseDFirst;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    public virtual ICollection<Team> Teams { get; } = new List<Team>();
}
