#pragma checksum "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfb2260fac82ccca502ed28d2d9c67a43aff59a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Details), @"mvc.1.0.view", @"/Views/Film/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\_ViewImports.cshtml"
using FilmLovers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\_ViewImports.cshtml"
using FilmLovers.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb2260fac82ccca502ed28d2d9c67a43aff59a", @"/Views/Film/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed963e57200d38dd775b965644fd919abd41080", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmLovers.Models.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\n\n<div>\n    <h4>Film</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 16 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 19 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 22 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Yil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 25 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Yil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 28 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Uzunluk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 31 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Uzunluk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 34 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IMDB_Puan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 37 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.IMDB_Puan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 40 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oyuncular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 43 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oyuncular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 46 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Afis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 49 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Afis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 52 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 55 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 58 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GosterimBaslangıc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 61 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.GosterimBaslangıc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 64 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GosterimBitis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 67 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.GosterimBitis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 70 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Konu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 73 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Konu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 76 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kategori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 79 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kategori.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cfb2260fac82ccca502ed28d2d9c67a43aff59a11507", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\Film\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cfb2260fac82ccca502ed28d2d9c67a43aff59a13647", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmLovers.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
