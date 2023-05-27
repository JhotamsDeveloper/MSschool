using MSschool.Application.Common;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

internal class CreateCommandHandler : ICommandHandler<CreateCommand, int>
{
    public async Task<int> Handle(CreateCommand command, CancellationToken cancellation)
    {
        await Task.CompletedTask;
        return command.Id;
    }
}
