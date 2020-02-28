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
    [Authorize]
    public class IndexAdminModel : PageModel
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly ILogger<IndexAdminModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexAdminModel(ILogger<IndexAdminModel> logger,ApplicationDbContext AppDbContext,SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> UserManager)
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
            var articles = from y in _AppDbContext.article select y;
            ViewData["articles"]=articles;
            var id1 = _userManager.Users.ToList();
            ViewData["list"]=id1;

        }
        public void OnPost(string id, string title, string image, string description,string identifier)
        {
            var articles = from i in _AppDbContext.article select i;
            ViewData["articles"]=articles;
            if(id.Contains("remove"))
            {
                var rmv = id.Replace("remove-","");
                var idRemove = Convert.ToInt32(rmv);
                var x = _AppDbContext.article.Find(idRemove);
                _AppDbContext.Remove(x);
                _AppDbContext.SaveChanges();
            }
            else if(identifier.Contains("edit"))
            {
                var x = _AppDbContext.article.Find(Convert.ToInt32(id));
                x.title = title;
                x.image = image;
                x.detail = description;
                x.created_at = DateTime.Now;
                x.UserId = "38081123-5ea6-436a-801f-840e8c70e2ce";
                _AppDbContext.SaveChanges();
            }
            else if(identifier.Contains("add"))
            {
                var n = new Articles
                {
                    title = title,
                    image = image,
                    detail = description,
                    created_at = DateTime.Now,
                    UserId = "38081123-5ea6-436a-801f-840e8c70e2ce"
                };
                _AppDbContext.Add(n);
                _AppDbContext.SaveChanges();

            }
        }
    }
}
