#pragma checksum "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291930f9cbb4a54823b7f97c100863c43ba96d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
#line 2 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291930f9cbb4a54823b7f97c100863c43ba96d79", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722218f3dee4d05c12a7b769fa3929121879b3cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Commerce.Areas.Admin.Models.urun>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
            BeginContext(170, 396, true);
            WriteLiteral(@"

<div class=""shop-tab-area"">
	<div class=""shop-tab-list"">
		<div class=""shop-tab-pill pull-left"">
			<ul>
				<li class=""active"" id=""left""><a data-toggle=""pill"" href=""#home""><i class=""fa fa-th""></i><span>Grid</span></a></li>
				<li><a data-toggle=""pill"" href=""#menu1""><i class=""fa fa-th-list""></i><span>List</span></a></li>
			</ul>
		</div>
		<div class=""shop-tab-pill pull-right"">
");
            EndContext();
#line 19 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
             using (Html.BeginForm("Index", "Shop", FormMethod.Get, new { id = "pageSizeForm" }))
			{

#line default
#line hidden
            BeginContext(662, 122, true);
            WriteLiteral("\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"product-size-deatils\">\r\n\t\t\t\t\t\t<div class=\"show-label\">\r\n\t\t\t\t\t\t\t<label>Göster : </label>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(785, 29, false);
#line 25 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                       Write(Html.DropDownList("pageSize"));

#line default
#line hidden
            EndContext();
            BeginContext(814, 176, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t\t<li class=\"product-size-deatils\">\r\n\t\t\t\t\t\t<div class=\"show-label\">\r\n\t\t\t\t\t\t\t<label><i class=\"fa fa-sort-amount-asc\"></i>Sırala: </label>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(991, 28, false);
#line 31 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                       Write(Html.DropDownList("orderBy"));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 40, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\tPage ");
            EndContext();
            BeginContext(1061, 57, false);
#line 35 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                     Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 4, true);
            WriteLiteral(" Of ");
            EndContext();
            BeginContext(1124, 15, false);
#line 35 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                                                    Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 13, true);
            WriteLiteral("\r\n\t\t\t\t</ul>\r\n");
            EndContext();
#line 37 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(1158, 145, true);
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n\t<div class=\"tab-content\">\r\n\t\t<div class=\"row tab-pane fade in active\" id=\"home\">\r\n\t\t\t<div class=\"shop-single-product-area\">\r\n");
            EndContext();
#line 43 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                 foreach (var item in Model)
				{/*grid görünümü */

#line default
#line hidden
            BeginContext(1362, 111, true);
            WriteLiteral("\t\t\t\t\t<div class=\"col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t<div class=\"single-banner\">\r\n\t\t\t\t\t\t\t<div class=\"product-wrapper\">\r\n");
            EndContext();
            BeginContext(1840, 24, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<a>\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1864, "\"", 1936, 1);
#line 53 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1871, Url.Action("productDetail","Shop",new { productId= item.urunId}), 1871, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1937, 65, true);
            WriteLiteral(" class=\"single-banner-image-wrapper\"></a>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2002, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291930f9cbb4a54823b7f97c100863c43ba96d7910038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2012, "~/images/", 2012, 9, true);
#line 55 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 2021, item.Resimyolu, 2021, 15, false);

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
            BeginContext(2065, 88, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"product-description\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"functional-buttons\">\r\n");
            EndContext();
            BeginContext(2335, 57, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0);\" id=\"addFavourite\"");
            EndContext();
            BeginWriteAttribute("productId", " productId=\"", 2392, "\"", 2416, 1);
#line 61 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2404, item.urunId, 2404, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2417, 150, true);
            WriteLiteral(" title=\"Beğen\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-heart-o\"></i>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\" title=\"Quick view\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(2568, 11, false);
#line 64 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                                                                    Write(item.urunId);

#line default
#line hidden
            EndContext();
            BeginContext(2579, 211, true);
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-compress\"></i>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"banner-bottom text-center\">\r\n\t\t\t\t\t\t\t\t<div class=\"banner-bottom-title\">\r\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2790, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291930f9cbb4a54823b7f97c100863c43ba96d7913353", async() => {
                BeginContext(2845, 13, false);
#line 72 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                                                     Write(item.urunName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2799, "~/Shop/productDetail/productId=", 2799, 31, true);
#line 72 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 2830, item.urunId, 2830, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2862, 317, true);
            WriteLiteral(@"
								</div>
								<div class=""rating-icon"">
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star""></i>
								</div>
							</div>
						</div>
					</div>
");
            EndContext();
#line 84 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(3186, 89, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<div id=\"menu1\" class=\"tab-pane fade\">\r\n\t\t\t<div class=\"row\">\r\n");
            EndContext();
#line 91 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                 foreach (var item in Model)
				{ /*list görünümü */

#line default
#line hidden
            BeginContext(3335, 121, true);
            WriteLiteral("\t\t\t\t\t<div class=\"single-shop-product\">\r\n\t\t\t\t\t\t<div class=\"col-xs-12 col-sm-5 col-md-4\">\r\n\t\t\t\t\t\t\t<div class=\"left-item\">\r\n");
            EndContext();
            BeginContext(3747, 24, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<a>\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3771, "\"", 3843, 1);
#line 100 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3778, Url.Action("productDetail","Shop",new { productId =item.urunId}), 3778, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3844, "\"", 3866, 1);
#line 100 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3852, item.urunName, 3852, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3867, 29, true);
            WriteLiteral("></a>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3896, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291930f9cbb4a54823b7f97c100863c43ba96d7917249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3906, "~/images/", 3906, 9, true);
#line 102 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 3915, item.Resimyolu, 3915, 15, false);

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
            BeginContext(3959, 148, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-xs-12 col-sm-7 col-md-8\">\r\n\t\t\t\t\t\t\t<div class=\"deal-product-content\">\r\n\t\t\t\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4107, "\"", 4182, 1);
#line 108 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 4114, Url.Action("productDetail","Shop", new { productId = item.urunId }), 4114, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4183, "\"", 4205, 1);
#line 108 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 4191, item.urunName, 4191, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4206, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4208, 13, false);
#line 108 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                                                                                                     Write(item.urunName);

#line default
#line hidden
            EndContext();
            BeginContext(4221, 94, true);
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t\t\t\t<div class=\"product-price\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"new-price\">₺ ");
            EndContext();
            BeginContext(4316, 10, false);
#line 111 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4326, 44, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<span class=\"old-price\">₺ ");
            EndContext();
            BeginContext(4372, 18, false);
#line 112 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                          Write(item.Price * 1.10m);

#line default
#line hidden
            EndContext();
            BeginContext(4391, 298, true);
            WriteLiteral(@"</span>
								</div>
								<div class=""list-rating-icon"">
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star icolor""></i>
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star""></i>
								</div>
								<p>");
            EndContext();
            BeginContext(4690, 17, false);
#line 121 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                              Write(item.urunAçıklama);

#line default
#line hidden
            EndContext();
            BeginContext(4707, 57, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<div class=\"availability\">\r\n\t\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(4766, 44, false);
#line 123 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                      Write(item.stock > 0 ? "Stokta Var" : "Stokta Yok");

#line default
#line hidden
            EndContext();
            BeginContext(4811, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            BeginContext(4943, 58, true);
            WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 129 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(5008, 42, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
#line 136 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
 foreach (var item in Model)
{   /*Quick View görünümü */

#line default
#line hidden
            BeginContext(5110, 24, true);
            WriteLiteral("\t<div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5134, "\"", 5151, 1);
#line 138 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5139, item.urunId, 5139, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5152, 432, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
				</div>
				<div class=""modal-body"">
					<div class=""modal-product"">
						<div class=""product-images"">
							<div class=""main-image images"">
								");
            EndContext();
            BeginContext(5584, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291930f9cbb4a54823b7f97c100863c43ba96d7923983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 148 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 5594, item.urunName, 5594, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5615, "~/images/", 5615, 9, true);
#line 148 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 5624, item.Resimyolu, 5624, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5667, 76, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"product-info\">\r\n\t\t\t\t\t\t\t<h1>");
            EndContext();
            BeginContext(5744, 13, false);
#line 152 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                           Write(item.urunName);

#line default
#line hidden
            EndContext();
            BeginContext(5757, 116, true);
            WriteLiteral("</h1>\r\n\t\t\t\t\t\t\t<div class=\"price-box\">\r\n\t\t\t\t\t\t\t\t<p class=\"s-price\"><span class=\"special-price\"><span class=\"amount\">₺");
            EndContext();
            BeginContext(5874, 10, false);
#line 154 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                                                                                                Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(5884, 44, true);
            WriteLiteral("</span></span></p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5928, "\"", 5999, 1);
#line 156 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5935, Url.Action("productDetail","Shop",new {productId=item.urunId }), 5935, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6000, 89, true);
            WriteLiteral(" class=\"see-all\">Detayı görmek için</a>\r\n\t\t\t\t\t\t\t<div class=\"quick-add-to-cart\">\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(6089, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291930f9cbb4a54823b7f97c100863c43ba96d7927719", async() => {
                BeginContext(6122, 210, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"numbers-row\">\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"number\" id=\"french-hens\" value=\"3\">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<button class=\"single_add_to_cart_button\" type=\"submit\">Sepete Ekle</button>\r\n\t\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6339, 58, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"quick-desc\">\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(6398, 17, false);
#line 166 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
                           Write(item.urunAçıklama);

#line default
#line hidden
            EndContext();
            BeginContext(6415, 984, true);
            WriteLiteral(@"
							</div>
							<div class=""social-sharing"">
								<div class=""widget widget_socialsharing_widget"">
									<h3 class=""widget-title-modal"">Paylaş</h3>
									<ul class=""social-icons"">
										<li><a target=""_blank"" title=""Facebook"" href=""#"" class=""facebook social-icon""><i class=""fa fa-facebook""></i></a></li>
										<li><a target=""_blank"" title=""Twitter"" href=""#"" class=""twitter social-icon""><i class=""fa fa-twitter""></i></a></li>
										<li><a target=""_blank"" title=""Pinterest"" href=""#"" class=""pinterest social-icon""><i class=""fa fa-pinterest""></i></a></li>
										<li><a target=""_blank"" title=""Google +"" href=""#"" class=""gplus social-icon""><i class=""fa fa-google-plus""></i></a></li>
										<li><a target=""_blank"" title=""LinkedIn"" href=""#"" class=""linkedin social-icon""><i class=""fa fa-linkedin""></i></a></li>
									</ul>
								</div>
							</div>
						</div><!-- .product-info -->
					</div>
				</div>
			</div>
		</div>
	</div>
");
            EndContext();
#line 186 "C:\Users\ibr günay\source\repos\Commerce\Views\Shop\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Commerce.Areas.Admin.Models.urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
