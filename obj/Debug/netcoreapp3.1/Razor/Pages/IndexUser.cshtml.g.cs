#pragma checksum "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fbc28bcaba16cf921095a5f2b9373adc65c3a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWeb.Pages.Pages_IndexUser), @"mvc.1.0.razor-page", @"/Pages/IndexUser.cshtml")]
namespace MyWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\_ViewImports.cshtml"
using MyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\_ViewImports.cshtml"
using MyWeb.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99fbc28bcaba16cf921095a5f2b9373adc65c3a6", @"/Pages/IndexUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2a1963ab096e24a901d25f0aa6677f57818403", @"/Pages/_ViewImports.cshtml")]
    public class Pages_IndexUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
  
    Layout="_LayoutUser";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <br><br><br><br>
<div class=""text-center"">
    <h1 class=""display-4"">Welcome To MagaZone</h1>
    <p>The Zone For You Who Want To Keep Uptodate On The Latest News</p>
    <hr class=""mb-4"">
</div>
    <section class=""blog-post-area section-margin mt-4"">
      <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 sidebar-widgets"">
              <div class=""widget-wrap"">
                <div class=""single-sidebar-widget newsletter-widget"">
                  <h4 class=""single-sidebar-widget__title"">What Do You Want ?</h4>
                  <div class=""form-group mt-30"">
                    <div class=""col-autos"">
                      <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Enter keyword"" onfocus=""this.placeholder = ''""
                        onblur=""this.placeholder = 'Enter email'"">
                    </div>
                  </div>
                  <button class=""bbtns d-block mt-20 w-100"">Search</button>
   ");
            WriteLiteral(@"             </div>


                <div class=""single-sidebar-widget post-category-widget"">
                  <h4 class=""single-sidebar-widget__title"">Catgory</h4>
                  <ul class=""cat-list mt-20"">
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">
                        <p>Technology</p>
                        <p>(03)</p>
                      </a>
                    </li>
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">
                        <p>Software</p>
                        <p>(09)</p>
                      </a>
                    </li>
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">
                        <p>Lifestyle</p>
                        <p>(12)</p>
                      </a>
                    </li>
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">");
            WriteLiteral(@"
                        <p>Shopping</p>
                        <p>(02)</p>
                      </a>
                    </li>
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">
                        <p>Food</p>
                        <p>(10)</p>
                      </a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
");
#nullable restore
#line 66 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
      
        ViewBag.articles = ViewData["articles"];
        ViewBag.name = ViewData["name"];

        foreach(var item in ViewBag.articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-8\">\r\n            <div class=\"single-recent-blog-post\">\r\n              <div class=\"thumb\">\r\n                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2885, "\"", 2902, 1);
#nullable restore
#line 75 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
WriteAttributeValue("", 2891, item.image, 2891, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2903, "\"", 2909, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul class=\"thumb-info\">\r\n");
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                    
                    ViewBag.list = ViewData["list"];
                    foreach(var i in ViewBag.list)
                    {
                      if(i.Id == @item.UserId)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\"><i class=\"ti-user\"></i>");
#nullable restore
#line 83 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                                                          Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 84 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                      }
                    }
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li><a href=\"#\"><i class=\"ti-notepad\"></i>");
#nullable restore
#line 87 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                                                       Write(item.created_at.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 87 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                                                                            Write(item.created_at.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 87 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                                                                                                   Write(item.created_at.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n              </div>\r\n              <div class=\"details mt-20\">\r\n                <a href=\"blog-single.html\">\r\n                  <h3>");
#nullable restore
#line 92 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
                 Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </a>\r\n                <p class=\"tag-list-inline\">Tag: <a href=\"#\">travel</a>, <a href=\"#\">life style</a>, <a href=\"#\">technology</a>, <a href=\"#\">fashion</a></p>\r\n                <p>");
#nullable restore
#line 95 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
              Write(item.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a class=\"button\" style=\"color: white;\" id=\"delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3924, "\"", 3976, 3);
            WriteAttributeValue("", 3934, "window.location.href=\'/Detail?id=", 3934, 33, true);
#nullable restore
#line 96 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
WriteAttributeValue("", 3967, item.id, 3967, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3975, "\'", 3975, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Read More <i class=\"ti-arrow-right\"></i></a>\r\n              </div>\r\n            </div>\r\n            </div>\r\n            <div class=\"col-lg-4 sidebar-widgets\">\r\n              <div class=\"widget-wrap\">\r\n              </div></div>\r\n");
#nullable restore
#line 103 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexUser.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexUserModel>)PageContext?.ViewData;
        public IndexUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
