#pragma checksum "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb0bd4e787e858ad7a19e371e9b233a40f163c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_NewProduct), @"mvc.1.0.view", @"/Views/Shop/NewProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/NewProduct.cshtml", typeof(AspNetCore.Views_Shop_NewProduct))]
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
#line 1 "C:\Users\ibr günay\source\repos\Commerce\Views\_ViewImports.cshtml"
using Commerce;

#line default
#line hidden
#line 2 "C:\Users\ibr günay\source\repos\Commerce\Views\_ViewImports.cshtml"
using Commerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb0bd4e787e858ad7a19e371e9b233a40f163c2", @"/Views/Shop/NewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722218f3dee4d05c12a7b769fa3929121879b3cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_NewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Commerce.Areas.Admin.Models.urun>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(89, 61, true);
            WriteLiteral("\t<div class=\"single-seller\">\r\n\t\t<div class=\"seller-img\">\r\n\t\t\t");
            EndContext();
            BeginContext(150, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfb0bd4e787e858ad7a19e371e9b233a40f163c24229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 160, "~/images/", 160, 9, true);
#line 7 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
AddHtmlAttributeValue("", 169, item.Resimyolu, 169, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(212, 49, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"seller-details\">\r\n\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 261, "\"", 335, 1);
#line 10 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
WriteAttributeValue("", 268, Url.Action("productDetail","Shop", new { productId = item.urunId}), 268, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(336, 5, true);
            WriteLiteral("><h5>");
            EndContext();
            BeginContext(342, 13, false);
#line 10 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
                                                                                         Write(item.urunName);

#line default
#line hidden
            EndContext();
            BeginContext(355, 20, true);
            WriteLiteral("</h5></a>\r\n\t\t\t<h5>₺ ");
            EndContext();
            BeginContext(376, 10, false);
#line 11 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
             Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(386, 285, true);
            WriteLiteral(@"</h5>
			<ul>
				<li><i class=""fa fa-star icolor""></i></li>
				<li><i class=""fa fa-star icolor""></i></li>
				<li><i class=""fa fa-star icolor""></i></li>
				<li><i class=""fa fa-star icolor""></i></li>
				<li><i class=""fa fa-star icolor""></i></li>
			</ul>
		</div>
	</div>
");
            EndContext();
#line 21 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\NewProduct.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Commerce.Areas.Admin.Models.urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
