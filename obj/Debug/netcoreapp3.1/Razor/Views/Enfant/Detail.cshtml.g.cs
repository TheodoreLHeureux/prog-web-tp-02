#pragma checksum "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486ab72965625a648452cedd3e152981b494191d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enfant_Detail), @"mvc.1.0.view", @"/Views/Enfant/Detail.cshtml")]
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
#line 1 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
using prog_web_tp_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486ab72965625a648452cedd3e152981b494191d", @"/Views/Enfant/Detail.cshtml")]
    public class Views_Enfant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Enfant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
  
    Layout = "_Layout";
    Enfant GPU = Model;

    string getImgPath(int i)
    {
        return "/images/GPUs/" + GPU.Parent.Nom.Replace(' ', '-') + "/" + GPU.Nom.Replace(' ', '-') + "/" + GPU.Nom.Replace(' ', '-') + "-" + i.ToString() + ".jpg";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/style/detail.css\">\r\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        $('.myCarousel').carousel();

        function normalizeSlideHeights() {
            $('.carousel').each(function () {
                var items = $('.carousel-item', this);
                items.css('min-height', 0);
                var maxHeight = Math.max.apply(null,
                    items.map(function () {
                        return $(this).outerHeight()
                    }).get());
                items.css('min-height', maxHeight + 'px');
            })
        }

        $(window).on(
            'load resize orientationchange',
            normalizeSlideHeights);
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\" id=\"details-container\">\r\n    <h1>Détails sur cette carte graphiques.</h1>\r\n    <div class=\"row details-row\">\r\n        <!-- Details -->\r\n        <div class=\"col-12 col-lg-4 col-xl-3 details\">\r\n            <h3>");
#nullable restore
#line 47 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
            Write(GPU.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul>\r\n                <li><b>Fabricant:</b> ");
#nullable restore
#line 49 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                 Write(GPU.Parent.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Chipset:</b> ");
#nullable restore
#line 50 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                               Write(GPU.Chipset.ToString().Replace('_', ' '));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Memory:</b> ");
#nullable restore
#line 51 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                              Write(GPU.Memory);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</li>\r\n                <li><b>Memory Type:</b> ");
#nullable restore
#line 52 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                   Write(GPU.MemType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Boost Clock:</b> ");
#nullable restore
#line 53 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                   Write(GPU.BoostClock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MHz</li>\r\n                <li><b>Core Clock:</b> ");
#nullable restore
#line 54 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                  Write(GPU.CoreClock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MHz</li>\r\n                <li><b>Length:</b> ");
#nullable restore
#line 55 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                              Write(GPU.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mm</li>\r\n                <li><b>TDP:</b> ");
#nullable restore
#line 56 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                           Write(GPU.TDP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" W</li>\r\n                <li><b>HDMI Ports:</b> ");
#nullable restore
#line 57 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                  Write(GPU.HDMIPorts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>DP Ports:</b> ");
#nullable restore
#line 58 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                Write(GPU.DPPorts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Maximum resolution:</b> ");
#nullable restore
#line 59 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                                          Write(GPU.MaxRes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Prix:</b> ");
#nullable restore
#line 60 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
                            Write(GPU.Prix.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</li>\r\n            </ul>\r\n            <form action=\"https://www.w3schools.com/action_page.php\" method=\"post\">\r\n                <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2229, "\"", 2244, 1);
#nullable restore
#line 63 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
WriteAttributeValue("", 2237, GPU.Id, 2237, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <button type=""submit"" class=""btn btn-primary"">Favoris <i class=""fas fa-plus""></i></button>
            </form>
        </div>
        <!-- Carousel -->
        <div class=""col-12 col-lg-8 col-xl-9"" id=""carousel-col"">
            <div id=""carouselDetailsIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselDetailsIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselDetailsIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselDetailsIndicators"" data-slide-to=""2""></li>
                    <li data-target=""#carouselDetailsIndicators"" data-slide-to=""3""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 3158, "\"", 3178, 1);
#nullable restore
#line 78 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
WriteAttributeValue("", 3164, getImgPath(1), 3164, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block img-fluid\" alt=\"GPU-with-Box\">\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3332, "\"", 3352, 1);
#nullable restore
#line 81 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
WriteAttributeValue("", 3338, getImgPath(2), 3338, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block img-fluid\" alt=\"GPU-front\">\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3503, "\"", 3523, 1);
#nullable restore
#line 84 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
WriteAttributeValue("", 3509, getImgPath(3), 3509, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block img-fluid\" alt=\"GPU-back\">\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3673, "\"", 3693, 1);
#nullable restore
#line 87 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
WriteAttributeValue("", 3679, getImgPath(4), 3679, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block img-fluid"" alt=""GPU-IO"">
                    </div>
                </div>
                <button class=""carousel-control-prev carousel-control"" type=""button"" data-target=""#carouselDetailsIndicators"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only "">Previous</span>
                </button>
                <button class=""carousel-control-next carousel-control"" type=""button"" data-target=""#carouselDetailsIndicators"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only "">Next</span>
                </button>
            </div>
        </div>
    </div>

    <div class=""row description"">
        <h3>Description</h3>
        <p>
            ");
#nullable restore
#line 105 "C:\Users\theod\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
       Write(GPU.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Enfant> Html { get; private set; }
    }
}
#pragma warning restore 1591
