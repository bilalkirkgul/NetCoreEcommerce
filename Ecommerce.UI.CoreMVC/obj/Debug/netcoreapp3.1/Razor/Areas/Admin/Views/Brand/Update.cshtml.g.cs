#pragma checksum "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Brand\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa1d323001304844392eaa3727540fa0122f7eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa1d323001304844392eaa3727540fa0122f7eb", @"/Areas/Admin/Views/Brand/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8b3dcfe84a7b01b69dee8dc55254f903ea5023", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brand_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BrandVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "put", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Brand\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"checkout-area pt-130 hm-3-padding pb-100 mt-100\">\r\n    <div class=\"container-fluid\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-md-9 col-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1d323001304844392eaa3727540fa0122f7eb5275", async() => {
                WriteLiteral(@"
                    <div class=""checkbox-form"">
                        <h3>Update Brand</h3>
                        <div class=""row"">
                            <div id=""alert"">

                            </div>
                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Brand Name<span class=""required"">*</span></label>
                                    <input type=""text"" id=""brandName"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Description<span class=""required"">*</span></label>
                                    <input type=""text"" id=""description"" class=""form-control"">
                                </div>
                            </div>

                        </div>");
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>


        <div class=""row"">
            <div class=""col-lg-6 col-md-9 col-9"">
                <div class=""order-button-payment"">
                    <input type=""submit"" id=""btnBrandUpdate"" value=""Update Brand"">
                </div>

            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n                 var id=");
#nullable restore
#line 55 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Brand\Update.cshtml"
                   Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

             $.ajax({
            type: ""GET"",
            url: ""http://localhost:61714/api/Brand/GetBrandById/"" + id,
                     success: function (data) {
                            
                            $(""#brandName"").val(data.brandName);
                            $(""#description"").val(data.description);
                     }
             });

        });

        $(""#btnBrandUpdate"").click(function () {
            var brand = new Object();
            brand.BrandID =");
#nullable restore
#line 71 "C:\Users\bilal_whzt3dm\Desktop\sertifika projesi\NetCoreEcommerce\Ecommerce.UI.CoreMVC\Areas\Admin\Views\Brand\Update.cshtml"
                      Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            brand.BrandName = $(""#brandName"").val();
            brand.Description = $(""#description"").val();
           
            $.ajax({
                url: ""http://localhost:61714/Api/Brand/UpdateBrand"",
                type: ""POST"",
                contentType: ""application/json; charset=utf-8"",
                data: JSON.stringify(brand),
                success: function (data) {
                    if (data.check==true) {
                        $(""#alert"").html(""<div class='alert alert-success' role='alert'>"" + data.message + ""</div>"")
                        window.location = ""/Admin/Brand/Index"";
                    } else {
                        $(""#alert"").html(""<div class='alert alert-danger' role='alert'>"" + data.message + ""</div>"")
                    }
                  

                }
            });
        });



    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BrandVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591