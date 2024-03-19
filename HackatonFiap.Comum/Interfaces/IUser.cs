﻿using System.Security.Claims;

namespace HackatonFiap.Comum.Interfaces;

public interface IUser
{
    string? Name { get; }
    Guid GetUserId();
    string? GetUserEmail();
    bool IsAuthenticated();
    bool IsInRole(string role);
    bool IsInRole(string role, string valor);
    IEnumerable<Claim>? GetClaimsIdentity();
}