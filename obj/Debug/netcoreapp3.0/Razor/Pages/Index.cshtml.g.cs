#pragma checksum "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5261aa364533b25d300e898db3a001a82c663ab4b914284ba26b37fdfc8bb7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContactManager.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using ContactManager

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using ContactManager.Data

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using ContactManager.Authorization;

#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
using ContactManager.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b5261aa364533b25d300e898db3a001a82c663ab4b914284ba26b37fdfc8bb7b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"75cd530dce2d0e5a60fc13ad7a4627756c7a03e58ad03db0bb71d9d5ff0cd562", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Contact Manager</h1>
    <p><b>  Welcom to the Group Project Build by </b></p>
    <p>Varankumar Patel - 200544591</p>
    <p>Sanat Sunny - 2005576550</p>
    <p>Athul Kakkuzhiyil - 200503634 </p>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 9 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
IAuthorizationService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 9 "C:\Users\ASUS\Downloads\IESP\Contact-Manager\Pages\_ViewImports.cshtml"
AuthorizationService

#line default
#line hidden
#nullable disable
         { get; private set; }
         = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
