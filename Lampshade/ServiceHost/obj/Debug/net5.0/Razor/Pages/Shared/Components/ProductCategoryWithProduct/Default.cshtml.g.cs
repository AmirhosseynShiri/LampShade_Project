#pragma checksum "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8b0d27ebd9b5b92370df9115061e01f924d5a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct.Pages_Shared_Components_ProductCategoryWithProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct
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
#nullable restore
#line 1 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
using _01_LampshadeQuery.Contract.ProductCategory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8b0d27ebd9b5b92370df9115061e01f924d5a6", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_ProductCategoryWithProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryQueryModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
 <div class=""single-row-slider-tab-area section-space"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  section title  =======-->
                    <div class=""section-title-wrapper text-center section-space--half"">
                        <h2 class=""section-title"">?????????????? ????</h2>
                        <p class=""section-subtitle"">Mirum est notare quam littera gothica, quam nunc putamus parum
                            claram anteposuerit litterarum formas.</p>
                    </div>
                    <!--=======  End of section title  =======-->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  tab slider wrapper  =======-->

                    <div class=""tab-slider-wrapper"">
                        <!--=======  tab product navigation  =======-->

                        <div class=""tab-product-n");
            WriteLiteral("avigation\">\r\n                            <div class=\"nav nav-tabs justify-content-center\" id=\"nav-tab2\" role=\"tablist\">\r\n");
#nullable restore
#line 26 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                 foreach (var category in Model)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <a");
            BeginWriteAttribute("class", " class=\"", 1373, "\"", 1439, 3);
            WriteAttributeValue("", 1381, "nav-item", 1381, 8, true);
            WriteAttributeValue(" ", 1389, "nav-link", 1390, 9, true);
#nullable restore
#line 28 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1398, Model.First()==category? "active" :"", 1399, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1440, "\"", 1469, 2);
            WriteAttributeValue("", 1445, "product-tab-", 1445, 12, true);
#nullable restore
#line 28 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1457, category.Id, 1457, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                    href=\"", 1488, "\"", 1560, 2);
            WriteAttributeValue("", 1532, "#product-series-", 1532, 16, true);
#nullable restore
#line 29 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1548, category.Id, 1548, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
#nullable restore
#line 29 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n");
#nullable restore
#line 30 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>

                        <!--=======  End of tab product navigation  =======-->
                        <!--=======  tab product content  =======-->
                        <div class=""tab-content"">
");
#nullable restore
#line 37 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                             foreach (var category in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div");
            BeginWriteAttribute("class", " class=\"", 2048, "\"", 2115, 4);
            WriteAttributeValue("", 2056, "tab-pane", 2056, 8, true);
            WriteAttributeValue(" ", 2064, "fade", 2065, 5, true);
            WriteAttributeValue(" ", 2069, "show", 2070, 5, true);
#nullable restore
#line 39 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 2074, Model.First()==category? "active" :"", 2075, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2116, "\"", 2148, 2);
            WriteAttributeValue("", 2121, "product-series-", 2121, 15, true);
#nullable restore
#line 39 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 2136, category.Id, 2136, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel""
                                aria-labelledby=""product-tab-1"">
                                <!--=======  single row slider wrapper  =======-->
                                <div class=""single-row-slider-wrapper"">
                                    
                                    <div class=""ht-slick-slider"" data-slick-setting='{
                                    ""slidesToShow"": 4,
                                    ""slidesToScroll"": 1,
                                    ""arrows"": true,
                                    ""autoplay"": false,
                                    ""autoplaySpeed"": 5000,
                                    ""speed"": 1000,
                                    ""infinite"": true,
                                    ""rtl"": true,
                                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevr");
            WriteLiteral(@"on-right"" }
                                }' data-slick-responsive='[
                                    {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                                ]'>
");
#nullable restore
#line 63 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                  foreach (var product in category.Products )
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                     <div class=""col"">
                                            <!--=======  single grid product  =======-->
                                            <div class=""single-grid-product"">
                                                <div class=""single-grid-product__image"">
");
#nullable restore
#line 69 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                     if(product.HasDiscount)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <div class=\"single-grid-product__label\">\r\n                                                         <span class=\"sale\">-");
#nullable restore
#line 72 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                        Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                         </div>  \r\n");
#nullable restore
#line 74 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8b0d27ebd9b5b92370df9115061e01f924d5a614039", async() => {
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be8b0d27ebd9b5b92370df9115061e01f924d5a614351", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4991, "~/ProductPictures/", 4991, 18, true);
#nullable restore
#line 76 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5009, product.Picture, 5009, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 77 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5111, product.PictureAlt, 5111, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 77 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5139, product.PictureTitle, 5139, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                             WriteLiteral(product.Slug);

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
            WriteLiteral(@"
                                                </div>
                                                <div class=""single-grid-product__content"">
                                                    <div class=""single-grid-product__category-rating"">
                                                        <span class=""category"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8b0d27ebd9b5b92370df9115061e01f924d5a619435", async() => {
#nullable restore
#line 83 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                                    Write(product.Category);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                              WriteLiteral(category.Slug);

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
            WriteLiteral(@"</span>
                                                        <span class=""rating"">
                                                            <i class=""ion-android-star active""></i>
                                                            <i class=""ion-android-star active""></i>
                                                            <i class=""ion-android-star active""></i>
                                                            <i class=""ion-android-star active""></i>
                                                            <i class=""ion-android-star-outline""></i>
                                                        </span>
                                                    </div>

                                                    <h3 class=""single-grid-product__title""> 
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8b0d27ebd9b5b92370df9115061e01f924d5a622866", async() => {
#nullable restore
#line 94 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                             WriteLiteral(product.Slug);

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
            WriteLiteral("\r\n                                                    </h3>\r\n\r\n                                                    <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 98 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                         if(product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                              <span class=\"discounted-price\">");
#nullable restore
#line 100 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                        Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????????</span>\r\n                                                                <span class=\"main-price discounted\">");
#nullable restore
#line 101 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????????</span>\r\n");
#nullable restore
#line 102 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                               <span class=\"main-price \">");
#nullable restore
#line 105 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????????</span>\r\n");
#nullable restore
#line 106 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </p>
                                                </div>
                                            </div>
                                            <!--=======  End of single grid product  =======-->
                                        </div>
");
#nullable restore
#line 113 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
    
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 </div>\r\n                                </div>\r\n                                <!--=======  End of single row slider wrapper  =======-->\r\n                            </div>\r\n");
#nullable restore
#line 119 "E:\Atriya\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                       
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
                        </div>
                        <!--=======  End of tab product content  =======-->
                    </div>

                    <!--=======  End of tab slider wrapper  =======-->
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCategoryQueryModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
