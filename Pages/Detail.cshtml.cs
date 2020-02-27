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
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly ILogger<DetailModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public DetailModel(ILogger<DetailModel> logger,ApplicationDbContext AppDbContext,SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> UserManager)
        {
            _logger = logger;
            _AppDbContext = AppDbContext;
            _userManager = UserManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public Articles Articles {get;set;}

        public void OnGet(int id)
        { 
            var article = _AppDbContext.article.Find(id);
            ViewData["article"]=article;
            var comment = from i in _AppDbContext.comments select i;
            ViewData["comment"]=comment;
        }
        public IActionResult OnPost(string comment, int id)
        {
            var idUser = _userManager.GetUserId(User);
            var email = _userManager.GetUserName(User);
            var cmnt = comment;
            var x = new Comments
            {
                userId = idUser,
                comment = cmnt
            };
            _AppDbContext.Add(x);
            _AppDbContext.SaveChanges();
            return Redirect("Detail?id="+id);
        }
    }
}
