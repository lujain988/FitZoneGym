using System;
using System.Collections.Generic;

namespace FitZone.Server.Models;

public partial class MealPlan
{
    public int MealPlanId { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<SubMealPlan> SubMealPlans { get; set; } = new List<SubMealPlan>();
}
