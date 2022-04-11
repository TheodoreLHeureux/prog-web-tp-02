#pragma checksum "C:\Users\theod\Documents\Dev\prog-web-tp-02\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddab289ccf0cc9ba130a6c2b5e8aba5cc9dc1468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddab289ccf0cc9ba130a6c2b5e8aba5cc9dc1468", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"fr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddab289ccf0cc9ba130a6c2b5e8aba5cc9dc14682731", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""icon"" href=""/images/icon.png"" media=""(prefers-color-scheme:light)"">
    <link rel=""icon"" href=""/images/icon-dark-theme.png"" media=""(prefers-color-scheme:dark)"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.0/css/all.min.css"" crossorigin=""anonymous"" integrity=""sha256-ybRkN9dBjhcS2qrW1z+hfCxq+1aBdwyQM5wlQoQVt/0="" />
    <link rel=""stylesheet"" type=""text/css"" href=""/style/sitewide.css"">
    ");
#nullable restore
#line 13 "C:\Users\theod\Documents\Dev\prog-web-tp-02\Views\Shared\_Layout.cshtml"
Write(RenderSection("Style", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <title>Accueil</title>

    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""></script>

    <script>
        $(document).ready(function () {
            if (!window.matchMedia)
                return;

            var current = $('head > link[rel=""icon""][media]');
            $.each(current, function (i, icon) {
                var match = window.matchMedia(icon.media);

                function swap() {
                    if (match.matches) {
                        current.remove();
                        current = $(icon).appendTo('head');
                    }
                }
                match.addListener(swap);
                swap();
            });
        });
    </script>
    ");
#nullable restore
#line 40 "C:\Users\theod\Documents\Dev\prog-web-tp-02\Views\Shared\_Layout.cshtml"
Write(RenderSection("Script", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddab289ccf0cc9ba130a6c2b5e8aba5cc9dc14685907", async() => {
                WriteLiteral(@"
    <header class=""container-fluid"">
        <nav class=""navbar navbar-expand-md navbar-light"">
            <a href=""/Home"" class=""navbar-brand"">
                <img class=""img-fluid"" src=""/images/icon.png"" alt=""Icon"" width=""60"">
            </a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav "">
                    <li class=""nav-item mr-auto""><a class=""nav-link"" href=""/Home"">GPUSelector</a></li>
                </ul>
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item""><a class=""nav-link"" href=""/Home"">Accueil</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/Enfant/Recherche""");
                WriteLiteral(">Recherche</a></li>\r\n                    <li class=\"nav-item\"><a class=\"nav-link\" href=\"/Favoris\">Favoris</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    <main class=\"container-fluid\">\r\n        ");
#nullable restore
#line 66 "C:\Users\theod\Documents\Dev\prog-web-tp-02\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <footer class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col col-12 col-md-auto"">
                <h3>Liens Utiles</h3>
                <ul>
                    <li><a href=""/Home"">Accueil</a></li>
                    <li><a href=""/Recherche/Index"">Recherche</a></li>
                    <li><a href=""/Favoris"">Favoris</a></li>
                </ul>
            </div>
            <div class=""col col-12 col-md-auto"">
                <h3>Nous contacter</h3>
                <ul>
                    <li>Téléphone: 514-123-4567</li>
                    <li>Courriel: support@gpuselector.com</li>
                    <li>Twitter: ");
                WriteLiteral(@"@GPUSelector</li>
                </ul>
            </div>
            <div class=""col col-12 col-md-auto"">
                <h3>Nos forces</h3>
                <ul>
                    <li>Rabais imbattables</li>
                    <li>Politique de prix</li>
                    <li>Politique de remboursement</li>
                </ul>
            </div>
        </div>
        <div class=""container"">
            <div class=""row justify-content-center "">
                <h2>GPUSelector 2022</h2>
            </div>
        </div>
    </footer>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</html>");
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
