#pragma checksum "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd2c1fedbd7ba4d007116606e1846100cb097f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VideoGameListings_Index), @"mvc.1.0.view", @"/Views/VideoGameListings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd2c1fedbd7ba4d007116606e1846100cb097f0", @"/Views/VideoGameListings/Index.cshtml")]
    public class Views_VideoGameListings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EAD2CA2.VideoGameListing>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 25 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 28 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 743, "\"", 766, 1);
#nullable restore
#line 34 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
WriteAttributeValue("", 758, item.ID, 758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 818, "\"", 841, 1);
#nullable restore
#line 35 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
WriteAttributeValue("", 833, item.ID, 833, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 895, "\"", 918, 1);
#nullable restore
#line 36 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
WriteAttributeValue("", 910, item.ID, 910, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 39 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EAD2CA2.VideoGameListing>> Html { get; private set; }
    }
}
#pragma warning restore 1591