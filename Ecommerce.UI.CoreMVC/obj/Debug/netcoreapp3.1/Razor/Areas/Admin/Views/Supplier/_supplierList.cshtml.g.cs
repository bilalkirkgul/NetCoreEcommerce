#pragma checksum "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "523c21c68c9caf61b8c9313b91024a53529a62ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Supplier__supplierList), @"mvc.1.0.view", @"/Areas/Admin/Views/Supplier/_supplierList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"523c21c68c9caf61b8c9313b91024a53529a62ef", @"/Areas/Admin/Views/Supplier/_supplierList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8b3dcfe84a7b01b69dee8dc55254f903ea5023", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Supplier__supplierList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SupplierVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-style btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Supplier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<thead>
    <tr>
        <th class=""product-name"">ID</th>
        <th class=""product-name"">CompanyName</th>
        <th class=""product-name"">Adress</th>
        <th class=""product-name"">City</th>
        <th class=""product-name"">Country</th>
        <th class=""product-name"">Phone Number</th>
        <th class=""product-name"">IsActive</th>
        <th class=""product-name"">Update</th>
        <th class=""product-subtotal"">delete</th>
    </tr>
</thead>
<tbody>

");
#nullable restore
#line 20 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
     foreach (SupplierVM item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 23 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.SupplierID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 24 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 25 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 26 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 27 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 28 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.PhoneNummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 29 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                      Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "523c21c68c9caf61b8c9313b91024a53529a62ef8424", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                                                                                                                  WriteLiteral(item.SupplierID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n");
#nullable restore
#line 36 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                 if (!item.IsActive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button style=\"border-style:none\" href=\"#\" disabled class=\"btn-style btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1567, "\"", 1609, 3);
            WriteAttributeValue("", 1577, "SupplierDelete(", 1577, 15, true);
#nullable restore
#line 38 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
WriteAttributeValue("", 1592, item.SupplierID, 1592, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1608, ")", 1608, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 39 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button style=\"border-style:none\" href=\"#\" class=\"btn-style btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1781, "\"", 1823, 3);
            WriteAttributeValue("", 1791, "SupplierDelete(", 1791, 15, true);
#nullable restore
#line 43 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
WriteAttributeValue("", 1806, item.SupplierID, 1806, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1822, ")", 1822, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 44 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\_supplierList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</tbody>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SupplierVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591