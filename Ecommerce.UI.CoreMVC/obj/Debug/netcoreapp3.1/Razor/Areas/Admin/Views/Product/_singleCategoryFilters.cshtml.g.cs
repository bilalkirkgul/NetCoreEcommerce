#pragma checksum "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Product\_singleCategoryFilters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a5c7ac3f8fdfe0fc7c5b9ba6cea6abc8ce83eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__singleCategoryFilters), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_singleCategoryFilters.cshtml")]
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
#line 2 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\_ViewImports.cshtml"
using Ecommerce.UI.CoreMVC.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a5c7ac3f8fdfe0fc7c5b9ba6cea6abc8ce83eb", @"/Areas/Admin/Views/Product/_singleCategoryFilters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8b3dcfe84a7b01b69dee8dc55254f903ea5023", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__singleCategoryFilters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h5>Kategoriler</h5>\r\n<ul class=\"sort-by\">\r\n    <li><a href=\"#\" onclick=\"GetProductListAll()\">Tüm Kategoriler</a> </li>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Product\_singleCategoryFilters.cshtml"
     foreach (CategoryVM item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 225, "\"", 264, 3);
            WriteAttributeValue("", 235, "GetCategory(", 235, 12, true);
#nullable restore
#line 11 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Product\_singleCategoryFilters.cshtml"
WriteAttributeValue("", 247, item.CategoryID, 247, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 263, ")", 263, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Product\_singleCategoryFilters.cshtml"
                                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 12 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Product\_singleCategoryFilters.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
