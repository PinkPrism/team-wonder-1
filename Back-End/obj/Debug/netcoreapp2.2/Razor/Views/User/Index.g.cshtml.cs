#pragma checksum "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73b684defb2316b09edb0819088db4d9f3b8052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73b684defb2316b09edb0819088db4d9f3b8052", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<backEnd.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(243, 44, false);
#line 16 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.userName));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 44, false);
#line 19 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(387, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(505, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(554, 43, false);
#line 28 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.userName));

#line default
#line hidden
            EndContext();
            BeginContext(597, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(653, 43, false);
#line 31 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.password));

#line default
#line hidden
            EndContext();
            BeginContext(696, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 771, "\"", 794, 1);
#line 34 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
WriteAttributeValue("", 786, item.id, 786, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(795, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 847, "\"", 870, 1);
#line 35 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
WriteAttributeValue("", 862, item.id, 862, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(871, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 925, "\"", 948, 1);
#line 36 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
WriteAttributeValue("", 940, item.id, 940, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(949, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\alina\Desktop\team-wonder-1\Back-End\Views\User\Index.cshtml"
}

#line default
#line hidden
            BeginContext(999, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<backEnd.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
