#pragma checksum "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f3ddb8464e3a2071128504a3c2dc09899a41a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWeb.Pages.Pages_IndexAdmin), @"mvc.1.0.razor-page", @"/Pages/IndexAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f3ddb8464e3a2071128504a3c2dc09899a41a6", @"/Pages/IndexAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2a1963ab096e24a901d25f0aa6677f57818403", @"/Pages/_ViewImports.cshtml")]
    public class Pages_IndexAdmin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
  
    Layout="_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
              <br><br><br><br>
    <h1 class=""display-4"">Welcome Admin</h1>
    <p>Manage Your Articles To Always Update</p>
    <button type=""button"" class=""btn btn-info"" style=""background-color: deepskyblue; border-color:grey;width:150px;height:40px;"" data-toggle=""modal"" data-target=""#exampleModal1"">Add</button>
</div>
    <hr class=""mb-4"">

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
                        onblur=""this.pla");
            WriteLiteral(@"ceholder = 'Enter email'"">
                    </div>
                  </div>
                  <button class=""bbtns d-block mt-20 w-100"">Search</button>
                </div>


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
                        <p>(12");
            WriteLiteral(@")</p>
                      </a>
                    </li>
                    <li>
                      <a href=""#"" class=""d-flex justify-content-between"">
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
#line 68 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
      
        ViewBag.articles = ViewData["articles"];
        ViewBag.name = ViewData["name"];

        foreach(var item in ViewBag.articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-8\">\r\n            <div class=\"single-recent-blog-post\">\r\n              <div class=\"thumb\">\r\n                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 3049, "\"", 3066, 1);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
WriteAttributeValue("", 3055, item.image, 3055, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3067, "\"", 3073, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul class=\"thumb-info\">\r\n");
#nullable restore
#line 79 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                     
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
#line 85 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                          Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 86 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                      }
                    }
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li><a href=\"#\"><i class=\"ti-notepad\"></i>");
#nullable restore
#line 89 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                       Write(item.created_at.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 89 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                            Write(item.created_at.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 89 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                   Write(item.created_at.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n              </div>\r\n              <div class=\"details mt-20\">\r\n                <a href=\"blog-single.html\">\r\n                  <h3>");
#nullable restore
#line 94 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                 Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </a>\r\n                <p class=\"tag-list-inline\">Tag: <a href=\"#\">travel</a>, <a href=\"#\">life style</a>, <a href=\"#\">technology</a>, <a href=\"#\">fashion</a></p>\r\n                <p>");
#nullable restore
#line 97 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
              Write(item.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"container\">\r\n                  <div class=\"row\">\r\n                <a class=\"button\" style=\"color: white;\" id=\"delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4167, "\"", 4219, 3);
            WriteAttributeValue("", 4177, "window.location.href=\'/Detail?id=", 4177, 33, true);
#nullable restore
#line 100 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
WriteAttributeValue("", 4210, item.id, 4210, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4218, "\'", 4218, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Read More <i class=\"ti-arrow-right\"></i></a>\r\n                &nbsp&nbsp&nbsp");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f3ddb8464e3a2071128504a3c2dc09899a41a611131", async() => {
                WriteLiteral("\r\n                    <a class=\"button\" type=\"button text-center\" style=\"color:white;width:155px;\"");
                BeginWriteAttribute("id", " id=\"", 4416, "\"", 4434, 2);
                WriteAttributeValue("", 4421, "edit-", 4421, 5, true);
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
WriteAttributeValue("", 4426, item.id, 4426, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                                        Write(item.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-title=\"");
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                                                              Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-created=\"");
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                                                                                         Write(item.created_at);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-detail=\"");
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                                                                                                                        Write(item.detail);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-image=\"");
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
                                                                                                                                                                                                                                  Write(item.image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspEdit<i class=\"ti-arrow-right\"></i></a>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                &nbsp&nbsp&nbsp");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f3ddb8464e3a2071128504a3c2dc09899a41a615229", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4810, "\"", 4833, 2);
                WriteAttributeValue("", 4818, "remove-", 4818, 7, true);
#nullable restore
#line 105 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
WriteAttributeValue("", 4825, item.id, 4825, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\">\r\n                    <button type=\"submit\" class=\"button text-center\" style=\"color:white;width:155px;\" id=\"delete\" >Delete</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n            </div>\r\n            <div class=\"col-lg-4 sidebar-widgets\">\r\n              <div class=\"widget-wrap\">\r\n              </div>\r\n              </div>\r\n");
#nullable restore
#line 117 "D:\Users\bsi50129\.vscode\Task MVVM\MyWeb\Pages\IndexAdmin.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>
    </div>
</section>
<div class=""modal"" id=""exampleModal"" tabindex=""-1"" role=""dialog"">
      <div class=""modal-dialog"" role=""document"" >
        <div class=""modal-content"" style=""width:500px;height:640px"">
          <div class=""modal-header"">
            <h4 class=""modal-title""><b>Update Data</b></h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f3ddb8464e3a2071128504a3c2dc09899a41a618338", async() => {
                WriteLiteral(@"
          <div class=""modal-body text-center"">
            <label for=""title""><b>Title</b></label><br>
            <input type=""text"" name=""identifier"" class=""form-control"" value=""edit"" hidden>
            <input type=""text"" name=""id"" id=""id1"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 6089, "\"", 6097, 0);
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n            <input style=\"height: 80px;\" type=\"text\" name=\"title\" id=\"title1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6206, "\"", 6214, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <br><br>\r\n\r\n            <label for=\"description\"><b>Description</b></label><br>\r\n            <input style=\"height: 80px;\" type=\"text\"  name=\"description\" id=\"description1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6422, "\"", 6430, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <br><br>\r\n\r\n            <label for=\"image\"><b>Image</b></label><br>\r\n            <input style=\"height: 80px;\" type=\"text\" name=\"image\" id=\"image1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6613, "\"", 6621, 0);
                EndWriteAttribute();
                WriteLiteral(@">
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color: red;color:white;"" id=""close"">Close</button>
            <button type=""submit"" class=""btn btn-primary"" id=""savechanges"" id=""edit"">Save changes</button>
          </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
    </div>
    <div class=""modal"" id=""exampleModal1"" tabindex=""-1"" role=""dialog"">
      <div class=""modal-dialog"" role=""document"" >
        <div class=""modal-content"" style=""width:500px;height:640px"">
          <div class=""modal-header"">
            <h4 class=""modal-title""><b>Add Data</b></h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f3ddb8464e3a2071128504a3c2dc09899a41a622144", async() => {
                WriteLiteral(@"
          <div class=""modal-body text-center"">
            <label for=""title""><b>Title</b></label><br>
            <input type=""text"" name=""identifier"" class=""form-control"" value=""add"" hidden>
            <input type=""text"" name=""id"" id=""id1"" class=""form-control"" value=""add"" hidden>
            <input style=""height: 60px;"" type=""text"" name=""title"" id=""title2"" class=""form-control"">
            <br><br>

            <label for=""description""><b>Description</b></label><br>
            <input style=""height: 60px;"" type=""text""  name=""description"" id=""description2"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 8119, "\"", 8127, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <br><br>\r\n\r\n            <label for=\"image\"><b>Image</b></label><br>\r\n            <input style=\"height: 60px;\" type=\"text\" name=\"image\" id=\"image2\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 8310, "\"", 8318, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <br><br><br><br>

          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color: red;color:white;"" id=""close"">Close</button>
            <button type=""submit"" class=""btn btn-primary"" id=""savechanges"" id=""add"">Add Data</button>
          </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
    integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n""
    crossorigin=""anonymous""></script>
<script>
    $(document).ready(function(){
        console.log('Masuk Sini')
        $('#exampleModal').on('show.bs.modal', function (e) {
        $('#id1').val($(e.relatedTarget).data('id'))
        $('#title1').val($(e.relatedTarget).data('title'))
        $('#description1').val($(e.relatedTarget).data('detail'))
        $('#image1').val($(e.relatedTarget).data('image'))
    })})
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexAdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexAdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexAdminModel>)PageContext?.ViewData;
        public IndexAdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
