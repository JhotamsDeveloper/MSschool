namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public sealed class CreateCommand
{
    public required int Id { get; set; }
    public required string? Name { get; set; }
}
