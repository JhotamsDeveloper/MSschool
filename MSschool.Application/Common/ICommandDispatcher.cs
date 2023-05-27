﻿namespace MSschool.Application.Common;

public interface ICommandDispatcher
{
    Task<TCommandResult> Dispatch<TCommand, TCommandResult>(
        TCommand command, CancellationToken cancellation);
}
