using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class IndexUserModel : PageModel
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly ILogger<IndexUserModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexUserModel(ILogger<IndexUserModel> logger,ApplicationDbContext AppDbContext,SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> UserManager)
        {
            _logger = logger;
            _AppDbContext = AppDbContext;
            _userManager = UserManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public Articles Articles {get;set;}

        public void OnGet()
        { 
            var articles = from i in _AppDbContext.article select i;
            ViewData["articles"]=articles;


        }
    }
}
