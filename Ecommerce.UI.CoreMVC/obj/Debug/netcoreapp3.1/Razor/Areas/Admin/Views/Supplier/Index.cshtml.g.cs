#pragma checksum "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254cd595a521b5430002430b8b425e9407183886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Supplier_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Supplier/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"254cd595a521b5430002430b8b425e9407183886", @"/Areas/Admin/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8b3dcfe84a7b01b69dee8dc55254f903ea5023", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Supplier\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""product-cart-area hm-3-padding pt-120 pb-130 mt-100"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div id=""alert"">

                </div>
                <div class=""table-content table-responsive"">
                    <table id=""supplierList"">
");
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>

        $(document).ready(function () {

            GetSupplierListAll()
        })

       
        function GetSupplierListAll() {
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:61714/api/Supplier/GetSuppliersFull"",

                success: function (response) {
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:61710/Admin/Supplier/GetSupplierList"",//client url
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        success: function (data) {
                            $(""#supplierList"").html(data);
                        }
                    });
                }

            })
        }

        function SupplierDelete(supid) {
            var cvp = confirm(""Tedarikçiyi silmek istediğine emin misiniz ?"")

            if (cvp) {
                $.ajax({");
                WriteLiteral(@"
                    type: ""GET"",
                    url: ""http://localhost:61714/api/Supplier/DeleteSupplierById/"" + supid,
                    success: function (data) {
                        if (cvp) {
                            alert(data.message)
                            location.reload();
                        }
                    },
                 

                });
            }

        }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
