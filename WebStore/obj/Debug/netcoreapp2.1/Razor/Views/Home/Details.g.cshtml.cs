#pragma checksum "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c65882d7bd96fd81901dbbb86292bb5e39dd64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c65882d7bd96fd81901dbbb86292bb5e39dd64c", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.EmployeeView>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(37, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(66, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d64e78739b143ca80622e793f0bf89f", async() => {
                BeginContext(72, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(170, 490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f2f0db79a54339ad41bfee3c230a54", async() => {
                BeginContext(176, 219, true);
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>Фамилия</td>\r\n            <td>Имя</td>\r\n            <td>Отчество</td>\r\n            <td>Возраст</td>\r\n            <td>Отдел</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
                EndContext();
                BeginContext(396, 15, false);
#line 20 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(411, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(435, 13, false);
#line 21 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Model.SurName);

#line default
#line hidden
                EndContext();
                BeginContext(448, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(472, 16, false);
#line 22 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Model.Patronymic);

#line default
#line hidden
                EndContext();
                BeginContext(488, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(512, 9, false);
#line 23 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Model.Age);

#line default
#line hidden
                EndContext();
                BeginContext(521, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(545, 16, false);
#line 24 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Model.Department);

#line default
#line hidden
                EndContext();
                BeginContext(561, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(585, 32, false);
#line 25 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Details.cshtml"
           Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(617, 36, true);
                WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(660, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.EmployeeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
