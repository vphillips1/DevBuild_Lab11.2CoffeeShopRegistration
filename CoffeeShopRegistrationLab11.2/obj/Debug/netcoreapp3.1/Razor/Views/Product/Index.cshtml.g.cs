#pragma checksum "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362a3ad3f995d2690b0f78dc1d6f8044cc0a1b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\_ViewImports.cshtml"
using CoffeeShopRegistrationLab11._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\_ViewImports.cshtml"
using CoffeeShopRegistrationLab11._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"362a3ad3f995d2690b0f78dc1d6f8044cc0a1b97", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e36aad544f85c91f78c53a87e9e1638843f3d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background-color: #5F9EA0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Coffee Menu</h1>
<h4>What would you like?</h4>
<h6>We have a variety of coffee, teas, and sandwiches and a few bakery items</h6>


<table class=""table table-bordered"">

    <thead>
        <tr>

            <th>Name</th>

            <th>Price</th>


        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 25 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"
         foreach (Product product in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 505, "\"", 539, 2);
            WriteAttributeValue("", 512, "/product/detail/", 512, 16, true);
#nullable restore
#line 33 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"
WriteAttributeValue("", 528, product.id, 528, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 33 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"
                                                      Write(product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("</a><br />\r\n                </td>\r\n\r\n                <td>\r\n                     $");
#nullable restore
#line 37 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"
                 Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Product\Index.cshtml"





        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "362a3ad3f995d2690b0f78dc1d6f8044cc0a1b975961", async() => {
                WriteLiteral("\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
