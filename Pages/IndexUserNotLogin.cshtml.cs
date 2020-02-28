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
    public class IndexUserNotLoginModel : PageModel
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly ILogger<IndexUserNotLoginModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexUserNotLoginModel(ILogger<IndexUserNotLoginModel> logger,ApplicationDbContext AppDbContext,SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> UserManager)
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
            var id1 = _userManager.Users.ToList();
            ViewData["list"]=id1;
            var comments = from i in _AppDbContext.comments select i;
            ViewData["comments"]= comments;
        }
    }
}
