using System;
using System.Collections.Generic;

namespace Lesson23DatabaseDFirst;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CoachId { get; set; }

    public int GroupId { get; set; }

    public int? Rate { get; set; }

    public virtual Coach Coach { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;

    public virtual ICollection<Schedule> ScheduleTeamANavigations { get; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleTeamBNavigations { get; } = new List<Schedule>();
}
