#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bd9cd1b06c7198b9603b8a3266e0ae06129e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Show), @"mvc.1.0.view", @"/Views/Products/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Show.cshtml", typeof(AspNetCore.Views_Products_Show))]
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
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bd9cd1b06c7198b9603b8a3266e0ae06129e5c", @"/Views/Products/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d42f4350f1f3362e85ee8c25291f0db794e203", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerceBundle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Destroy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 213, true);
            WriteLiteral("<!-- Insert Model Here -->\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-10 rounded justify-content-center m-4 bg-white\">\r\n        <div class=\"row justify-content-center m-3\">\r\n            <h1>");
            EndContext();
            BeginContext(238, 18, false);
#line 6 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
           Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(256, 205, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        \r\n        <div class=\"row justify-content-start m-3\">\r\n            <div class=\"col-3\">\r\n                <div class=\"row justify-content-center m-1\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 461, "\"", 487, 1);
#line 12 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
WriteAttributeValue("", 467, Model.Product.Image, 467, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(488, 25, true);
            WriteLiteral(" class=\"product-img mb-2\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 513, "\"", 546, 2);
#line 12 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
WriteAttributeValue("", 519, Model.Product.Name, 519, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 538, "Picture", 539, 8, true);
            EndWriteAttribute();
            BeginContext(547, 174, true);
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-9 justify-content-start\">\r\n                <div class=\"row m-1\">\r\n                    <h5>Creator: ");
            EndContext();
            BeginContext(722, 31, false);
#line 17 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                            Write(Model.Product.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(753, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(755, 30, false);
#line 17 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                                             Write(Model.Product.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(785, 115, true);
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"row mx-1 mt-1 mb-3\">\r\n                    <h5>Quantity: ");
            EndContext();
            BeginContext(901, 22, false);
#line 20 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                             Write(Model.Product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(923, 210, true);
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"row m-1\">\r\n                    <h5>Description:</h5>\r\n                </div>\r\n                <div class=\"row mx-1 mt-1 mb-3\">\r\n                    <p>");
            EndContext();
            BeginContext(1134, 25, false);
#line 26 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                  Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 46, true);
            WriteLiteral("</p>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1206, 41, false);
#line 28 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
           Write(Html.Partial("~/Views/Orders/New.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                 if(Model.Product.AccountId == ViewBag.AccountId)
                {

#line default
#line hidden
            BeginContext(1335, 247, true);
            WriteLiteral("                    <hr>\r\n                    <div class=\"row m-1 justify-content-start\">\r\n                        <h5>Remove Product?</h5>\r\n                    </div>\r\n                    <div class=\"row mx-1 mt-1 mb-4\">\r\n                        ");
            EndContext();
            BeginContext(1582, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07142dd58c3c4531ab13c8f6b5d9ff18", async() => {
                BeginContext(1689, 121, true);
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-danger mt-2\">Remove</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                                                               WriteLiteral(Model.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1817, 56, true);
            WriteLiteral("\r\n                    </div>\r\n                    <hr>\r\n");
            EndContext();
            BeginContext(1894, 35, false);
#line 41 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
               Write(Html.Partial("Edit", new Product()));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 26, true);
            WriteLiteral("                    <hr>\r\n");
            EndContext();
#line 43 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                }

#line default
#line hidden
            BeginContext(1976, 182, true);
            WriteLiteral("                <div class=\"row m-1\">\r\n                    <h5>Current Orders:</h5>\r\n                </div>\r\n                <div class=\"row mx-3 mt-1 mb-3 justify-content-center\">\r\n");
            EndContext();
#line 48 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                      
                        // Checks Customer list for objects, if none display text, otherwise display list
                        if(Model.Product.Customers.Count == 0)
                        {

#line default
#line hidden
            BeginContext(2380, 89, true);
            WriteLiteral("                            <h6 class=\"text-danger text-center\">No Current Orders!</h6>\r\n");
            EndContext();
#line 53 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2553, 490, true);
            WriteLiteral(@"                            <table class=""table table-striped"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th scope=""col w-25"">User</th>
                                    <th scope=""col w-25"">Quantity</th>
                                    <th scope=""col w-25"">Creation Date</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 65 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                 foreach(var order in Model.Product.Customers)
                                {

#line default
#line hidden
            BeginContext(3158, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3245, 23, false);
#line 68 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                       Write(order.Account.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3268, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3270, 22, false);
#line 68 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                                                Write(order.Account.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3344, 12, false);
#line 69 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                       Write(order.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(3356, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3408, 39, false);
#line 70 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                       Write(order.CreatedAt.ToString("MMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3447, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 72 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                                }

#line default
#line hidden
            BeginContext(3532, 72, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
            EndContext();
#line 75 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Products\Show.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3654, 78, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerceBundle> Html { get; private set; }
    }
}
#pragma warning restore 1591
