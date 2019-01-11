#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9546d58891a3d9b4680fdfff0e8f19a5eb8673f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Edit), @"mvc.1.0.view", @"/Views/Orders/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Edit.cshtml", typeof(AspNetCore.Views_Orders_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9546d58891a3d9b4680fdfff0e8f19a5eb8673f3", @"/Views/Orders/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d42f4350f1f3362e85ee8c25291f0db794e203", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
  
    // If Product quantity greater than 0, create Order form
    // else display 'Sold Out' message
    

#line default
#line hidden
#line 5 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
     if(@Model.Product.Quantity > 0)
    {

#line default
#line hidden
            BeginContext(165, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(173, 1980, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bf3ca057c64451e984291a957a48dd6", async() => {
                BeginContext(269, 135, true);
                WriteLiteral("\r\n            <div class=\"form-row justify-content-start mx-1 mb-4\">\r\n                <div class=\"col-md-6 mt-2\">\r\n                    ");
                EndContext();
                BeginContext(404, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbeaee59e5be46269276391c43de6cb9", async() => {
                    BeginContext(435, 74, true);
                    WriteLiteral("Add Amount <span class=\"font-weight-light\">(max 10 items per order)</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 10 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Amount);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(517, 101, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2 ml-1 mr-2 mt-2\">\r\n                    ");
                EndContext();
                BeginContext(618, 1113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0becb3f80fac4005938768955b0d27c7", async() => {
                    BeginContext(664, 303, true);
                    WriteLiteral(@"

                        // If Product Quantity < 10, populate select list with
                        // numbers up to Quantity, otherwise populate select list
                        // with numbers up to 10.

                        // Accounts for the current order
                        ");
                    EndContext();
#line 20 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                         if(@Model.Product.Quantity + (int)@Model.Amount <= 10)
                        {
                            var i = 1;
                            while(i <= @Model.Product.Quantity + (int)@Model.Amount)
                            {

#line default
#line hidden
                    BeginContext(1208, 39, true);
                    WriteLiteral("                                <option");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1247, "\"", 1257, 1);
#line 25 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 1255, i, 1255, 2, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1258, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(1260, 1, false);
#line 25 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                              Write(i);

#line default
#line hidden
                    EndContext();
                    BeginContext(1261, 9, true);
                    WriteLiteral("</option>");
                    EndContext();
#line 25 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                                              ;
                                i++;
                            }
                        }
                        else
                        {
                            var i = 1;
                            while(i <= 10)
                            {

#line default
#line hidden
                    BeginContext(1541, 39, true);
                    WriteLiteral("                                <option");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1580, "\"", 1590, 1);
#line 34 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 1588, i, 1588, 2, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1591, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(1593, 1, false);
#line 34 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                              Write(i);

#line default
#line hidden
                    EndContext();
                    BeginContext(1594, 9, true);
                    WriteLiteral("</option>");
                    EndContext();
#line 34 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                                              ;
                                i++;
                            }
                        }

#line default
#line hidden
                    BeginContext(1702, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Amount);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1731, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                     if(ViewBag.InvalidAction != null)
                    {

#line default
#line hidden
                BeginContext(1812, 53, true);
                WriteLiteral("                        <p><span class=\"text-danger\">");
                EndContext();
                BeginContext(1866, 21, false);
#line 41 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                                Write(ViewBag.InvalidAction);

#line default
#line hidden
                EndContext();
                BeginContext(1887, 13, true);
                WriteLiteral("</span></p>\r\n");
                EndContext();
#line 42 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                    }

#line default
#line hidden
                BeginContext(1923, 223, true);
                WriteLiteral("                </div>\r\n                <div class=\"col-md-2 align-self-center\">\r\n                    <button type=\"submit\" class=\"btn btn-success\">Update Order</button>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
                                                                          WriteLiteral(ViewBag.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2179, 70, true);
            WriteLiteral("        <h6 class=\"text-danger text-center\">Currently Sold Out!</h6>\r\n");
            EndContext();
#line 53 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ECommerce\Views\Orders\Edit.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591