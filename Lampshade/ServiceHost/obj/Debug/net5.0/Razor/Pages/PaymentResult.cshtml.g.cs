#pragma checksum "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e2d6d045dfd9f84bc99b48019b6d9e209dd09d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_PaymentResult), @"mvc.1.0.razor-page", @"/Pages/PaymentResult.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e2d6d045dfd9f84bc99b48019b6d9e209dd09d", @"/Pages/PaymentResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_PaymentResult : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
  
    ViewData["Title"] = "نتیجه ی پرداخت";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area section-space--half"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-wrapper breadcrumb-bg"">
                    <div class=""breadcrumb-content"">
                        <h1 class=""breadcrumb-content__title"">نتیجه ی پرداخت</h1>
                        <ul class=""breadcrumb-content__page-map"">
                            <li><a href=""/"">صفحه اصلی</a></li>
                            <li class=""active"">نتیجه ی پرداخت</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""page-content-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
");
#nullable restore
#line 29 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                 if (Model.Result.IsSuccessful)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success\">\r\n                        <h6>\r\n                            ");
#nullable restore
#line 33 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                       Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h6>\r\n");
#nullable restore
#line 35 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                         if (!string.IsNullOrWhiteSpace(Model.Result.IssueTrackingNo))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6>\r\n                                شماره پیگیری: <strong>");
#nullable restore
#line 38 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                                                 Write(Model.Result.IssueTrackingNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </h6>\r\n");
#nullable restore
#line 40 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 42 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        <h6>\r\n                            ");
#nullable restore
#line 47 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                       Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h6>\r\n                    </div>\r\n");
#nullable restore
#line 50 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.PaymentResultModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel>)PageContext?.ViewData;
        public ServiceHost.Pages.PaymentResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591