#pragma checksum "E:\C# Programs\TradingView\TradingView\Pages\FX\EURUSD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a719c80b1d9b00735257d9314d5ad048494dccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TradingView.Pages.FX.Pages_FX_EURUSD), @"mvc.1.0.razor-page", @"/Pages/FX/EURUSD.cshtml")]
namespace TradingView.Pages.FX
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
#line 1 "E:\C# Programs\TradingView\TradingView\Pages\_ViewImports.cshtml"
using TradingView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a719c80b1d9b00735257d9314d5ad048494dccc", @"/Pages/FX/EURUSD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099b780f5a11adf66e0356f040a2c0f99b5b79ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FX_EURUSD : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/trading.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a719c80b1d9b00735257d9314d5ad048494dccc3728", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a719c80b1d9b00735257d9314d5ad048494dccc3990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral(@"

<!-- TradingView Widget BEGIN -->
<div class=""tradingview-widget-container"">
    <div id=""tradingview_3180a""></div>
    <div class=""tradingview-widget-copyright""><a href=""https://ru.tradingview.com/symbols/EURUSD/?exchange=FX"" rel=""noopener"" target=""_blank""><span class=""blue-text"">График EURUSD</span></a> от TradingView</div>
    <script type=""text/javascript"" src=""https://s3.tradingview.com/tv.js""></script>
    <script type=""text/javascript"">
  new TradingView.widget(
  {
  ""width"": 980,
  ""height"": 610,
  ""symbol"": ""FX:EURUSD"",
  ""interval"": ""D"",
  ""timezone"": ""Etc/UTC"",
  ""theme"": ""light"",
  ""style"": ""3"",
  ""locale"": ""ru"",
  ""toolbar_bg"": ""#f1f3f6"",
  ""enable_publishing"": false,
  ""allow_symbol_change"": true,
  ""container_id"": ""tradingview_3180a""
}
  );
    </script>
</div>
<!-- TradingView Widget END -->


<!-- TradingView Widget BEGIN -->
<div class=""tradingview-widget-container"" id=""eurusdanalysis"">
  <div class=""tradingview-widget-container__widget""></div>
  <div class");
            WriteLiteral(@"=""tradingview-widget-copyright""><a href=""https://ru.tradingview.com/symbols/EURUSD/technicals/"" rel=""noopener"" target=""_blank""><span class=""blue-text"">Технический анализ EURUSD</span></a> от TradingView</div>
  <script type=""text/javascript"" src=""https://s3.tradingview.com/external-embedding/embed-widget-technical-analysis.js"" async>
  {
  ""interval"": ""1m"",
  ""width"": ""480"",
  ""isTransparent"": false,
  ""height"": ""450"",
  ""symbol"": ""FX:EURUSD"",
  ""showIntervalTabs"": true,
  ""locale"": ""ru"",
  ""colorTheme"": ""light""
}
  </script>
</div>
<!-- TradingView Widget END -->


<!-- TradingView Widget BEGIN -->
<div class=""tradingview-widget-container"" id=""eurusdprofile"">
  <div class=""tradingview-widget-container__widget""></div>
  <div class=""tradingview-widget-copyright""><a href=""https://ru.tradingview.com/symbols/EURUSD/?exchange=FX"" rel=""noopener"" target=""_blank""><span class=""blue-text"">Профиль EURUSD</span></a> от TradingView</div>
  <script type=""text/javascript"" src=""https://s3.tradingview.com");
            WriteLiteral("/external-embedding/embed-widget-symbol-profile.js\" async>\r\n  {\r\n  \"symbol\": \"FX:EURUSD\",\r\n  \"width\": 480,\r\n  \"height\": 650,\r\n  \"colorTheme\": \"light\",\r\n  \"isTransparent\": false,\r\n  \"locale\": \"ru\"\r\n}\r\n  </script>\r\n</div>\r\n<!-- TradingView Widget END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TradingView.Pages.FX.EURUSDModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TradingView.Pages.FX.EURUSDModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TradingView.Pages.FX.EURUSDModel>)PageContext?.ViewData;
        public TradingView.Pages.FX.EURUSDModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
