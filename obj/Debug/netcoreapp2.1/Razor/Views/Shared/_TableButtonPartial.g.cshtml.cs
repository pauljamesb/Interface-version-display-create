#pragma checksum "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84906446cb1b8b0f0468412a9bb0caae2cb16f6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\_ViewImports.cshtml"
using DOA;

#line default
#line hidden
#line 2 "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\_ViewImports.cshtml"
using DOA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84906446cb1b8b0f0468412a9bb0caae2cb16f6e", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09137cc7361579e27847f4e6a8d4a0ebe6b3af77", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 75, true);
            WriteLiteral("\r\n\r\n<td style=\"width: 150px;\">\r\n\r\n    <!--\r\n        <a type=\"button\" href=\"");
            EndContext();
            BeginContext(212, 28, false);
#line 11 "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\Shared\_TableButtonPartial.cshtml"
                          Write(Url.Action("Details/"+Model));

#line default
#line hidden
            EndContext();
            BeginContext(240, 54, true);
            WriteLiteral("\">Details</a>\r\n\r\n        -->\r\n\r\n\r\n    <a type=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 294, "\"", 327, 1);
#line 16 "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 301, Url.Action("Edit/"+Model), 301, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(328, 33, true);
            WriteLiteral(">Edit</a>\r\n\r\n    <a type=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 361, "\"", 396, 1);
#line 18 "C:\Users\pauljames\source\repos\DaysOutApp\V4\DOA\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 368, Url.Action("Delete/"+Model), 368, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 20, true);
            WriteLiteral(">Delete</a>\r\n\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
