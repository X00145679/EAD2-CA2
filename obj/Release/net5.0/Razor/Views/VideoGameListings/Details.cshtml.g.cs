#pragma checksum "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586208d59acd42ae709812715abb302f68ca2310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VideoGameListings_Details), @"mvc.1.0.view", @"/Views/VideoGameListings/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"586208d59acd42ae709812715abb302f68ca2310", @"/Views/VideoGameListings/Details.cshtml")]
    public class Views_VideoGameListings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EAD2CA2.VideoGameListing>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>VideoGameListing</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 14 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 20 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 609, "\"", 633, 1);
#nullable restore
#line 28 "/Users/graham/ead2_ca/EAD2-CA2/Views/VideoGameListings/Details.cshtml"
WriteAttributeValue("", 624, Model.ID, 624, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EAD2CA2.VideoGameListing> Html { get; private set; }
    }
}
#pragma warning restore 1591
