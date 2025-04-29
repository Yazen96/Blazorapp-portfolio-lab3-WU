using System.Text.Json.Serialization;

namespace Blazorapp_portfolio_lab3_WU.Models;

public partial class Skill
{
    [JsonIgnore]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int YearsOfExperience { get; set; }

    public string SkillLevel { get; set; } = null!;
}
