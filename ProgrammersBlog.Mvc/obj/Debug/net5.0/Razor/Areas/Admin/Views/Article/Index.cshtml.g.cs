#pragma checksum "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5f461db7385338782798812384a089cc0881326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Article_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Article/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f461db7385338782798812384a089cc0881326", @"/Areas/Admin/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.ArticleListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-image-table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm btn-update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/js/articleIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Makaleler";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb mb-3 mt-2\">\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f461db7385338782798812384a089cc08813266388", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f461db7385338782798812384a089cc08813267994", async() => {
                WriteLiteral("Makaleler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
</ol>
<div class=""card mb-4"">
    <div class=""card-header"">
        <i class=""fas fa-table mr-1""></i>
        Makaleler
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""articlesTable"" width=""100%"" cellspacing=""0"">
                <thead>
                <tr>
                    <th>#</th>
                    <th>Kategori</th>
                    <th>Başlık</th>
                    <th>Küçük Resim</th>
                    <th>Tarih</th>
                    <th>Okunma Sayısı</th>
                    <th>Yorum Sayısı</th>
                    <th>Aktif Mi?</th>
                    <th>Silinmiş Mi?</th>
                    <th>Oluşturulma Tarihi</th>
                    <th>Oluşturan Kullanıcı Adı</th>
                    <th>Son Düzenlenme Tarihi</th>
                    <th>Son Düzenleyen Kullanıcı Adı</th>
                    <th>İşlemler</th>
                </tr>
                </thead>
        ");
            WriteLiteral(@"        <tfoot>
                <tr>
                    <th>#</th>
                    <th>Kategori</th>
                    <th>Başlık</th>
                    <th>Küçük Resim</th>
                    <th>Tarih</th>
                    <th>Okunma Sayısı</th>
                    <th>Yorum Sayısı</th>
                    <th>Aktif Mi?</th>
                    <th>Silinmiş Mi?</th>
                    <th>Oluşturulma Tarihi</th>
                    <th>Oluşturan Kullanıcı Adı</th>
                    <th>Son Düzenlenme Tarihi</th>
                    <th>Son Düzenleyen Kullanıcı Adı</th>
                    <th>İşlemler</th>
                </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 55 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                 foreach (var article in Model.Articles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("name", " name=\"", 2225, "\"", 2243, 1);
#nullable restore
#line 57 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
WriteAttributeValue("", 2232, article.Id, 2232, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 60 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5f461db7385338782798812384a089cc088132613173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2437, "~/img/", 2437, 6, true);
#nullable restore
#line 61 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
AddHtmlAttributeValue("", 2443, article.Thumbnail, 2443, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 63 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 64 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 65 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                        Write(article.IsActive ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 66 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                        Write(article.IsDeleted ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                       Write(article.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f461db7385338782798812384a089cc088132618037", async() => {
                WriteLiteral("<span class=\"fas fa-edit\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                                                                             Write(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                                                                                                                                                                      WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"");
#nullable restore
#line 73 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                                                                                 Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 76 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f461db7385338782798812384a089cc088132622608", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function() {\r\n            $(\'#btnAdd\').click(function() {\r\n                window.location.href = \'");
#nullable restore
#line 89 "C:\Users\kapla\Downloads\Proje\ProgrammersBlog-Proje-Dosyasi-D209\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Article\Index.cshtml"
                                   Write(Url.Action("Add","Article"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    \r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.ArticleListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
