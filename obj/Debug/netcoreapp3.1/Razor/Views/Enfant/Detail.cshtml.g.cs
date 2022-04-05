#pragma checksum "C:\Users\2032422\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a8696a8c8506fb062f8e02e9b6ce95fdad5fcd0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8696a8c8506fb062f8e02e9b6ce95fdad5fcd0", @"/Views/Enfant/Detail.cshtml")]
    public class Views_Enfant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\2032422\OneDrive - Cégep Édouard-Montpetit\Hiver 2022\Programmation Web serveur\prog-web-tp-2\Views\Enfant\Detail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"style/detail.css\">\r\n");
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
            WriteLiteral(@"
<div class=""container-fluid"" id=""details-container"">
    <h1>Détails sur cette carte graphiques.</h1>
    <div class=""row details-row"">
        <!-- Details -->
        <div class=""col-12 col-lg-4 col-xl-3 details"">
            <h3>GeForce RTX 3070 Vision OC</h3>
            <ul>
                <li><b>Fabricant:</b> Gigabyte</li>
                <li><b>Chipset:</b> GeForce RTX 3070</li>
                <li><b>Memory:</b> 8 GB</li>
                <li><b>Memory Type:</b> GDDR6</li>
                <li><b>Boost Clock:</b> 1815 MHz</li>
                <li><b>Core Clock:</b> 1500 MHz</li>
                <li><b>Length:</b> 286 mm</li>
                <li><b>TDP:</b> 220 W</li>
                <li><b>HDMI Ports:</b> 2</li>
                <li><b>DP Ports:</b> 2</li>
                <li><b>Maximum resolution:</b> 8k</li>
                <li><b>Prix:</b> 780$</li>
            </ul>
            <form action=""https://www.w3schools.com/action_page.php"" method=""post"">
                <input type");
            WriteLiteral(@"=""hidden"" name=""nom"" value=""RTX-3070-Vision-OC"">
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
                        <img src=""images/GPUs/Gigabyte/RTX-3070-Vision-OC/RTX-3070-Vision-OC");
            WriteLiteral(@"-1.jpg"" class=""d-block img-fluid"" alt=""RTX-3070-Vision-OC-1.jpg"">
                    </div>
                    <div class=""carousel-item"">
                        <img src=""images/GPUs/Gigabyte/RTX-3070-Vision-OC/RTX-3070-Vision-OC-2.jpg "" class=""d-block img-fluid"" alt=""RTX-3070-Vision-OC-2.jpg"">
                    </div>
                    <div class=""carousel-item"">
                        <img src=""images/GPUs/Gigabyte/RTX-3070-Vision-OC/RTX-3070-Vision-OC-3.jpg"" class=""d-block img-fluid"" alt=""RTX-3070-Vision-OC-3.jpg"">
                    </div>
                    <div class=""carousel-item"">
                        <img src=""images/GPUs/Gigabyte/RTX-3070-Vision-OC/RTX-3070-Vision-OC-4.jpg"" class=""d-block img-fluid"" alt=""RTX-3070-Vision-OC-4.jpg"">
                    </div>
                </div>
                <button class=""carousel-control-prev carousel-control"" type=""button"" data-target=""#carouselDetailsIndicators"" data-slide=""prev"">
                    <span class=""carousel-control-");
            WriteLiteral(@"prev-icon"" aria-hidden=""true""></span>
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
            La puissante GeForce RTX™ Série 30 VISION accélère votre travail grâce à des performances incroyables. Que ce soit MONTAGE VIDÉO, ANIMATION 3D, PHOTOGRAPHIE, CONCEPTION GRAPHIQUE, ARCHITECTURE ou STREAMING, elle peut vous faire gagner
            beaucoup de temps.
        </p>
    </div>

</div>
<p id=""fixed-p"">Ceci est un element fixé.</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
