﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Creation
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Email is invalid")]
        public string? Email { get; init; }
        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; init; }
    }
}
