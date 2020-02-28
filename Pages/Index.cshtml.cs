using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Pages
{
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(ILogger<IndexModel> logger,ApplicationDbContext AppDbContext,SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> UserManager)
        {
            _logger = logger;
            _AppDbContext = AppDbContext;
            _userManager = UserManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public Articles Articles {get;set;}

        [Authorize]
        public IActionResult OnGet()
        { 
            var id = _userManager.GetUserId(User);
            if(id==null)
            {
                return new RedirectToPageResult("IndexUserNotLogin");
            }else{
            var id1 = _userManager.Users.ToList();
            var adminId = id1[0].Id;
            var x = from i in _AppDbContext.role select i;
            if( id==adminId)
            {
            if (!_AppDbContext.role.Any())
            {
                var role = new Roles
                    {
                        UserId = adminId,
                        status ="admin"
                    };
                 _AppDbContext.Add(role);
                 _AppDbContext.SaveChanges();
            }else{
                 var role = new Roles
                    {
                        UserId = adminId,
                        status ="admin"
                    };
                 _AppDbContext.Add(role);
                 _AppDbContext.SaveChanges();
            }
                return new RedirectToPageResult("IndexAdmin");
            }
            else
            {
                return new RedirectToPageResult("IndexUser");
            }
            }
        }
    }
}
