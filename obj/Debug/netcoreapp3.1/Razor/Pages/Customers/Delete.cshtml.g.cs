#pragma checksum "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773588fa7ce09adee6fff934875959fa50760398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MicahCustomerManager.Pages.Customers.Pages_Customers_Delete), @"mvc.1.0.razor-page", @"/Pages/Customers/Delete.cshtml")]
namespace MicahCustomerManager.Pages.Customers
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
#line 1 "/Users/arwenorford/Projects/MicahAppFinal/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arwenorford/Projects/MicahAppFinal/Pages/_ViewImports.cshtml"
using MicahCustomerManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/arwenorford/Projects/MicahAppFinal/Pages/_ViewImports.cshtml"
using MicahCustomerManager.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773588fa7ce09adee6fff934875959fa50760398", @"/Pages/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6261dcc228d4102a9f0cd93b0223de5c4964bd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773588fa7ce09adee6fff934875959fa507603985055", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773588fa7ce09adee6fff934875959fa507603986101", async() => {
                WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.DateOfBirth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.DateOfBirth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.MobileNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.MobileNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.EmailAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.EmailAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.PostalAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.PostalAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ProceduresPerformed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ProceduresPerformed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ProcedureDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ProcedureDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ProcedureDate1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ProcedureDate1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ProcedureDate2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ProcedureDate2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AdditionalProceduresDates));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AdditionalProceduresDates));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AllergiesNoted));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AllergiesNoted));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.MedicalNotes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.MedicalNotes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.PreviousMedicalComplications));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.PreviousMedicalComplications));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AntiobioticProcedureNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AntiobioticProcedureNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ProcedureNotes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ProcedureNotes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ConsentGiven));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ConsentGiven));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.UnderEighteen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.UnderEighteen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.MarketingSubscribed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.MarketingSubscribed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.PregnantBreastfeeding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 140 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.PregnantBreastfeeding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 143 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.NotesOnCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 146 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.NotesOnCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 149 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ReferralInformation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 152 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ReferralInformation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773588fa7ce09adee6fff934875959fa5076039820802", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "773588fa7ce09adee6fff934875959fa5076039821075", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 157 "/Users/arwenorford/Projects/MicahAppFinal/Pages/Customers/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Customer.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773588fa7ce09adee6fff934875959fa5076039822905", async() => {
                        WriteLiteral("Back to List");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MicahCustomerManager.Pages.Customers.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MicahCustomerManager.Pages.Customers.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MicahCustomerManager.Pages.Customers.DeleteModel>)PageContext?.ViewData;
        public MicahCustomerManager.Pages.Customers.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
