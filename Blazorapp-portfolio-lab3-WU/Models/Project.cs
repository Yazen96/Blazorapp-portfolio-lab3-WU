namespace Blazorapp_portfolio_lab3_WU.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Link { get; set; }
}
