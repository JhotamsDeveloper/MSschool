﻿using Microsoft.AspNetCore.Http;
using MSschool.Application.Contracts.Persistence;

namespace MSschool.Infrastructure.EntityFramework.Repositories;

internal sealed class AuditContexService : IAuditContex
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditContexService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetUserFromRecord()
    {
        string? name = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
        return name;
    }
}
