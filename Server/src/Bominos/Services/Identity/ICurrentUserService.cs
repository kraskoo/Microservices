﻿namespace Bominos.Services.Identity
{
    public interface ICurrentUserService
    {
        string UserId { get; }

        bool IsAdministrator { get; }
    }
}