using System;
using System.Collections.Generic;

namespace Lesson23DatabaseDFirst;

public partial class Schedule
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int TeamA { get; set; }

    public int TeamB { get; set; }

    public DateTime Time { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Team TeamANavigation { get; set; } = null!;

    public virtual Team TeamBNavigation { get; set; } = null!;
}
