#pragma checksum "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac8b415d9f90c5f63ebb2ce8d5c44a2ac79d29d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 1 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac8b415d9f90c5f63ebb2ce8d5c44a2ac79d29d", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255471837956cc974ac863edf4b322ceb182c5c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"


<section id=""services"" class=""services"">
    <div class=""container"" data-aos=""fade-up"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"" data-aos=""zoom-in"" data-aos-delay=""100"">
                <div class=""icon-box"">
                    <div class=""icon"">");
#nullable restore
#line 11 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\Service\Detail.cshtml"
                                 Write(Html.Raw(Model.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <h4><a href=\"#\"> ");
#nullable restore
#line 12 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\Service\Detail.cshtml"
                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <p>");
#nullable restore
#line 13 "C:\Users\seymu\Desktop\new project\WebApplication2\WebApplication2\Views\Service\Detail.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section><!-- End Services Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
