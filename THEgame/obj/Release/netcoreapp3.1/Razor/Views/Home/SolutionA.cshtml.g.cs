#pragma checksum "C:\THEgame\THEgame\THEgame\Views\Home\SolutionA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651819023ecc4f9c9e1bd7edc0c69aa60bf01baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SolutionA), @"mvc.1.0.view", @"/Views/Home/SolutionA.cshtml")]
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
#line 1 "C:\THEgame\THEgame\THEgame\Views\_ViewImports.cshtml"
using THEgame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\THEgame\THEgame\THEgame\Views\_ViewImports.cshtml"
using THEgame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651819023ecc4f9c9e1bd7edc0c69aa60bf01baf", @"/Views/Home/SolutionA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a0de58f6f78d56e10492fe8c4bacb248245b83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SolutionA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row mb-lg-n5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    input[type=\"email\"] {\r\n        width: 30px;\r\n        height: 30px;\r\n    }\r\n</style>\r\n<div style=\"margin-left: 10px; font-size: 22px; max-width: 400px;\">\r\n    <h4 class=\"display-4 border-bottom\">Special</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651819023ecc4f9c9e1bd7edc0c69aa60bf01baf3742", async() => {
                WriteLiteral(@"
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat0"" value=""Strength"">
        </div>        
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Perception"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Endurance"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Charisma"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />");
                WriteLiteral(@"
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Intelligence"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Agility"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
        <div class=""col-auto"">
            <input type=""text"" readonly class=""form-control-plaintext"" id=""stat1"" value=""Luck"">
        </div>
        <div class=""col-auto"">
            <input type=""email"" class=""form-control-sm"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
