#pragma checksum "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70da402fe2a4ded23667ed357272e7d954e5d4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FilmElestri_IcerikSayfasi), @"mvc.1.0.view", @"/Views/FilmElestri/IcerikSayfasi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70da402fe2a4ded23667ed357272e7d954e5d4cb", @"/Views/FilmElestri/IcerikSayfasi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed963e57200d38dd775b965644fd919abd41080", @"/Views/_ViewImports.cshtml")]
    public class Views_FilmElestri_IcerikSayfasi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilmLovers.Models.FilmElestri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Anime Section Begin -->\n");
#nullable restore
#line 5 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"anime-details spad\">\n    <div class=\"container\">\n        <div class=\"anime__details__content\">\n            <div class=\"row\">\n           \n                            <img class=\"product__item__pic set-bg\"");
            BeginWriteAttribute("src", " src=\"", 364, "\"", 391, 2);
            WriteAttributeValue("", 370, "..\\..\\", 370, 6, true);
#nullable restore
#line 12 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
WriteAttributeValue("", 376, item.Film.Afis, 376, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" />

                
                <div class=""col-lg-9"">
                    <div class=""anime__details__text"">
                        <div class=""anime__details__title"">
                            <h3>

                                ");
#nullable restore
#line 20 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                           Write(item.Film.FilmAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                            </h3>\n\n                        </div>\n\n                        <p>\n                            ");
#nullable restore
#line 27 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                       Write(item.Yazi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                        <div class=""anime__details__widget"">
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-6"">
                                    <ul>
                                        <li><span>Yıl: </span> ");
#nullable restore
#line 33 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                          Write(item.Film.Yil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    \n                                        <li><span>Konu: </span> ");
#nullable restore
#line 35 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                           Write(item.Film.Konu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><span>Oyuncular: </span>");
#nullable restore
#line 36 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                               Write(item.Film.Oyuncular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><span>Dil: </span> ");
#nullable restore
#line 37 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                          Write(item.Film.Dil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><span>Süre: </span>");
#nullable restore
#line 38 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                          Write(item.Film.Uzunluk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <br /><br /><br />\n                                        <li><span>Eleştiri Yazarı: </span> ");
#nullable restore
#line 40 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                                      Write(item.Yazar.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 40 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                                                      Write(item.Yazar.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><span>Yazar Puanı: </span> ");
#nullable restore
#line 41 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
                                                                  Write(item.YazarPuan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </div>
</section>");
#nullable restore
#line 54 "C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\Views\FilmElestri\IcerikSayfasi.cshtml"
          }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilmLovers.Models.FilmElestri>> Html { get; private set; }
    }
}
#pragma warning restore 1591
