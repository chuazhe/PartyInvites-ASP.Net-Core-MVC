#pragma checksum "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11dec124a967f52c593a313af5746abfabbd3ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites;

#line default
#line hidden
#line 2 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11dec124a967f52c593a313af5746abfabbd3ad", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e21af70e33a7c205d8bf678bceb4feaec54d3ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartyInvites.Models.GuestResponse>>
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
#line 2 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(82, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(107, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11dec124a967f52c593a313af5746abfabbd3ad3605", async() => {
                BeginContext(113, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Responses</title>\r\n");
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
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 565, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11dec124a967f52c593a313af5746abfabbd3ad4884", async() => {
                BeginContext(219, 260, true);
                WriteLiteral(@"
    <h2>Here is the list of people attending the party</h2>
    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 22 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
             foreach (PartyInvites.Models.GuestResponse r in Model)
            {

#line default
#line hidden
                BeginContext(563, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(610, 6, false);
#line 25 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
                   Write(r.Name);

#line default
#line hidden
                EndContext();
                BeginContext(616, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(648, 7, false);
#line 26 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
                   Write(r.Email);

#line default
#line hidden
                EndContext();
                BeginContext(655, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(687, 7, false);
#line 27 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
                   Write(r.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(694, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 29 "C:\Users\weizhchu\source\repos\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
            }

#line default
#line hidden
                BeginContext(739, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(778, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartyInvites.Models.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
