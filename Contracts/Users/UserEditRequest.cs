﻿using System;
using Dorbit.Framework.Entities.Abstractions;

namespace Dorbit.Identity.Contracts.Users;

public class UserEditRequest : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Cellphone { get; set; }
    public string Email { get; set; }
    public bool NeedResetPassword { get; set; }
    public short ActiveTokenCount { get; set; } = 1;
}