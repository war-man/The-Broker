﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Services
{
    public interface IOwnersService
    {
        Task<IEnumerable<SelectListItem>> GetOwners();
    }
}
