#pragma checksum "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Home\RegistrationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b93d971557e77419e2daf0c4356d10611359088"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistrationForm), @"mvc.1.0.view", @"/Views/Home/RegistrationForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b93d971557e77419e2daf0c4356d10611359088", @"/Views/Home/RegistrationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e36aad544f85c91f78c53a87e9e1638843f3d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistrationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/RegistrationResponse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #5F9EA0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\vphillips\dev\CoffeeShopRegistrationLab11.2\CoffeeShopRegistrationLab11.2\Views\Home\RegistrationForm.cshtml"
  
    ViewData["Title"] = "RegistrationForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Please fill the form to register! </h3>\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b93d971557e77419e2daf0c4356d106113590884906", async() => {
                WriteLiteral(@"

   
    <fieldset>
        <legend>Name</legend>

        <div class=""form-group"">
            FirstName: <input class=""form-control"" type=""text"" name=""FirstName"" placeholder=""Enter your First Name"" required /><br />

        </div>

        <div class=""form-group"">
            LastName: <input class=""form-control"" type=""text"" name=""LastName"" placeholder=""Enter your Last Name"" required /><br />


        </div>

        <div class=""form-group"">
            UserName: <input class=""form-control"" type=""text"" name=""UserName"" placeholder=""Enter your User Name"" required /><br />



        </div>



    </fieldset>

    

    <fieldset>
        <legend>Contact Information</legend>

        <div class=""form-group"">
            Email: <input class=""form-control"" type=""email"" name=""Email"" placeholder=""Enter your email address"" required /><br />

        </div>

        <div class=""form-group"">
            EmailConfirmation: <input class=""form-control"" type=""email"" name=""EmailCo");
                WriteLiteral(@"nfirmation"" placeholder=""Please confirm your email"" required /><br />

        </div>


        <div class=""form-group"">

            <div class=""form-group"">
                Age:<br /><small>You must be at least 18 years or older </small> <input class=""form-control"" type=""number"" name=""Age"" min=""18"" max=""1000"" placeholder=""Enter your age"" required /><br />

            </div>

            <label for=""birthday"">Birthday:</label>
            <input class=""form-control"" type=""date"" id=""birthday"" name=""birthday"" required /><br />


            PhoneNumber:<br /><small>Format: 123-456-7890</small><input class=""form-control"" type=""tel"" name=""PhoneNumber"" placeholder=""Enter your phone number"" pattern=""[0-9]{3}-[0-9]{3}-[0-9]{4}"" required />

        </div>
        <div>
            <label>Type of Phone Number: </label>
            <label class=""form-check-inline"">
                <input type=""checkbox"" class=""form-check-input"">
                Mobile
            </label>
            <label ");
                WriteLiteral(@"class=""form-check-inline"">
                <input type=""checkbox"" class=""form-check-input"">
                Work
            </label>
            <label class=""form-check-inline"">
                <input type=""checkbox"" class=""form-check-input"">
                Home
            </label>
        </div>


    </fieldset>

    
    <fieldset>

        <legend>Authentication</legend>
        <div class=""form-group"">
            Password: <input class=""form-control"" type=""password"" name=""Password"" placeholder=""Enter your password"" minlength=""8"" required /><br />

        </div>
        <div class=""form-group"">

            PasswordConfirmation: <input class=""form-control"" type=""password"" name=""PasswordConfirmation"" placeholder=""Confirm your password"" minlength=""8"" required>

        </div>


    </fieldset>


  
    <button class=""btn btn-dark"">Register</button>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b93d971557e77419e2daf0c4356d106113590889599", async() => {
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style type=""text/css"">

    .form2 input {
        background-color: #ffcc66;
    }
    .form {
       
        width: 500px;
        clear:both;
    }

        

        .form input {
            width: 100%;
            clear:both;
        
        }
</style>

<style>
    fieldset {
        background-color: #eeeeee;
    }

    legend {
        background-color: gray;
        color: burlywood;
        padding: 5px 10px;
    }

    input {
        margin: 0px;
    }
</style>

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
