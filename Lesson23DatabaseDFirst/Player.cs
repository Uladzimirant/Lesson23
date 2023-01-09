using System;
using System.Collections.Generic;

namespace Lesson23DatabaseDFirst;

public partial class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Surname { get; set; }

    public int? TeamId { get; set; }

    public int Age { get; set; }

    public int? Salary { get; set; }
}
