#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3fd507424a97522526ba5fc8cba9fced145056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Show), @"mvc.1.0.view", @"/Views/Accounts/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Show.cshtml", typeof(AspNetCore.Views_Accounts_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3fd507424a97522526ba5fc8cba9fced145056", @"/Views/Accounts/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d42f4350f1f3362e85ee8c25291f0db794e203", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Destroy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-link text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 213, true);
            WriteLiteral("<!-- Insert Model Here -->\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-10 rounded justify-content-center m-4 bg-white\">\r\n        <div class=\"row justify-content-center m-3\">\r\n            <h1>");
            EndContext();
            BeginContext(230, 15, false);
#line 6 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(245, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(247, 14, false);
#line 6 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                            Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(261, 195, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row justify-content-start m-3\">\r\n            <div class=\"col-3\">\r\n                <div class=\"row justify-content-center m-1\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 456, "\"", 474, 1);
#line 11 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
WriteAttributeValue("", 462, Model.Image, 462, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(475, 194, true);
            WriteLiteral(" class=\"user-img mb-2\">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-9 justify-content-start\">\r\n                <div class=\"row m-1\">\r\n                    <h5>Email: ");
            EndContext();
            BeginContext(670, 11, false);
#line 16 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(681, 115, true);
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"row mx-1 mt-1 mb-3\">\r\n                    <h5>Birthday: ");
            EndContext();
            BeginContext(797, 45, false);
#line 19 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                             Write(Model.Birthday.Value.ToString("MMMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(842, 69, true);
            WriteLiteral("</h5>\r\n                </div>\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(912, 20, false);
#line 22 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
           Write(Html.Partial("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(932, 206, true);
            WriteLiteral("\r\n                <hr>\r\n                <div class=\"row m-1\">\r\n                    <h5>Products Added:</h5>\r\n                </div>\r\n                <div class=\"row mx-3 mt-1 mb-3 justify-content-center\">\r\n");
            EndContext();
#line 28 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                      
                        // Checks CreatedProducts list for objects, if none display text, otherwise display list
                        if(Model.CreatedProducts.Count == 0)
                        {

#line default
#line hidden
            BeginContext(1365, 89, true);
            WriteLiteral("                            <h6 class=\"text-danger text-center\">No Added Products!</h6>\r\n");
            EndContext();
#line 33 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1538, 604, true);
            WriteLiteral(@"                            <table class=""table table-striped"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th scope=""col"">Product</th>
                                        <th scope=""col"">Quantity</th>
                                        <th scope=""col"">Creation Date</th>
                                        <th scope=""col"" class=""text-center w-25"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 46 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                     foreach(var product in Model.CreatedProducts)
                                    {

#line default
#line hidden
            BeginContext(2265, 115, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2380, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57f3edd6e6c841e7bae90854593e17fd", async() => {
                BeginContext(2462, 12, false);
#line 49 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                                                                 Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                                      WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2478, 76, true);
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2555, 16, false);
#line 50 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2571, 76, true);
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2648, 41, false);
#line 51 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                Write(product.CreatedAt.ToString("MMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2689, 220, true);
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">\r\n                                                <div class=\"row justify-content-center\">\r\n                                                    ");
            EndContext();
            BeginContext(2909, 306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5dbe6314546416e91a190941791c9aa", async() => {
                BeginContext(3010, 198, true);
                WriteLiteral("\r\n                                                        <button type=\"submit\" class=\"btn btn-sm btn-link text-danger\"><h6>Remove</h6></button>\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                           WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3215, 156, true);
            WriteLiteral("\r\n                                                </div>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3410, 80, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
            EndContext();
#line 63 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3540, 111, true);
            WriteLiteral("                </div>\r\n                <div class=\"row m-1 mb-4 justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3651, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bbfaf800854873989090d61e519806", async() => {
                BeginContext(3726, 15, true);
                WriteLiteral("Add New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3745, 135, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row m-1\">\r\n                    <h5>Account Orders:</h5>\r\n                </div>\r\n");
            EndContext();
#line 72 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                  
                    // Checks Orders list for objects, if none display text, else display list
                    if(Model.Orders.Count == 0)
                    {

#line default
#line hidden
            BeginContext(4068, 85, true);
            WriteLiteral("                        <h6 class=\"text-danger text-center\">No Current Orders!</h6>\r\n");
            EndContext();
#line 77 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4225, 649, true);
            WriteLiteral(@"                        <div class=""row my-1 mx-3"">
                            <table class=""table table-striped"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th scope=""col"">Product</th>
                                        <th scope=""col"">Quantity</th>
                                        <th scope=""col"">Order Date</th>
                                        <th scope=""col"" class=""text-center"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 91 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                     foreach(var order in Model.Orders)
                                    {

#line default
#line hidden
            BeginContext(4986, 115, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(5101, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48869ddbce242f28f1bdf27f4f1eefd", async() => {
                BeginContext(5189, 18, false);
#line 94 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                                                                       Write(order.Product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                                      WriteLiteral(order.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5211, 76, true);
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(5288, 12, false);
#line 95 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                Write(order.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(5300, 76, true);
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(5377, 39, false);
#line 96 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                Write(order.CreatedAt.ToString("MMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5416, 138, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center align-middle\">\r\n                                                ");
            EndContext();
            BeginContext(5554, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f5f10ac196b4e7fa6c71505cee7c839", async() => {
                BeginContext(5670, 10, true);
                WriteLiteral("View Order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                               WriteLiteral(order.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5684, 52, true);
            WriteLiteral(" /\r\n                                                ");
            EndContext();
            BeginContext(5736, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cc5100569d47cfacff39c3fc5f7b27", async() => {
                BeginContext(5831, 187, true);
                WriteLiteral("\r\n                                                    <button type=\"submit\" class=\"btn btn-sm btn-link text-danger\">Cancel Order</button>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                                                     WriteLiteral(order.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6025, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 104 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6164, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 108 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(6318, 246, true);
            WriteLiteral("                <hr>\r\n                <div class=\"row m-1 justify-content-center\">\r\n                    <h5>Delete Account</h5>\r\n                </div>\r\n                <div class=\"row mx-1 mt-1 mb-4 justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(6564, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d5e2cd160914cf2841a1d4959645208", async() => {
                BeginContext(6663, 121, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-danger mt-2\">Delete Account</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 115 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Accounts\Show.cshtml"
                                                                           WriteLiteral(Model.AccountId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6791, 80, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
