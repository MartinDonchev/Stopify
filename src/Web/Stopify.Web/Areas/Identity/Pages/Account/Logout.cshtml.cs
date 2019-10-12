﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Stopify.Data.Models;

namespace Stopify.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<StopifyUser> _signInManager;
        //private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<StopifyUser> signInManager)//, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
           // _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            await _signInManager.SignOutAsync();

             return Redirect("/Identity/Account/Login");
        }

    }
}