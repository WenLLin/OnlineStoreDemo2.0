#pragma checksum "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\OnlineStoreDemo2\OnlineStoreDemo2\CourseProjectDemo2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b45f0d53b1764b7838a2af6fcd96e7c829d3c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\OnlineStoreDemo2\OnlineStoreDemo2\CourseProjectDemo2\Views\_ViewImports.cshtml"
using CourseProjectDemo2;

#line default
#line hidden
#line 2 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\OnlineStoreDemo2\OnlineStoreDemo2\CourseProjectDemo2\Views\_ViewImports.cshtml"
using CourseProjectDemo2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b45f0d53b1764b7838a2af6fcd96e7c829d3c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc75c382f66e59baec0afc1bd137dc82d38aa8d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form d-flex navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:antiquewhite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\OnlineStoreDemo2\OnlineStoreDemo2\CourseProjectDemo2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(72, 1253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b45f0d53b1764b7838a2af6fcd96e7c829d3c86113", async() => {
                BeginContext(78, 1240, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Jekyll v3.8.5"">
    <title>POCS</title>
    <link href=""/docs/4.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">


    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }
    </style>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXC");
                WriteLiteral("bMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n    <link href=\"carousel.css\" rel=\"stylesheet\">\r\n    <link rel=\"canonical\" href=\"https://getbootstrap.com/docs/4.3/examples/blog/\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1325, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1327, 7851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b45f0d53b1764b7838a2af6fcd96e7c829d3c88623", async() => {
                BeginContext(1371, 554, true);
                WriteLiteral(@"
    <header>
        <div class=""nav-scroller py-1 mb-2"">
            <nav class=""nav d-flex justify-content-between"">
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Home</a>

                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Clothing</a>
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Electronics</a>
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Health & Personal Care</a>
                <a href=""#"">Clearance</a>
                ");
                EndContext();
                BeginContext(1925, 803, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b45f0d53b1764b7838a2af6fcd96e7c829d3c89590", async() => {
                    BeginContext(1997, 724, true);
                    WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Find cheap stuff"">
                        <div class=""input-group-btn"">

                            <a class=""text-muted"" href=""#"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""mx-3"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><title>Search</title><circle cx=""10.5"" cy=""10.5"" r=""7.5"" /><path d=""M21 21l-5.2-5.2"" /></svg>
                            </a>
                        </div>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                BeginContext(2728, 4689, true);
                WriteLiteral(@"
            </nav>
        </div>
    </header>

    <div class=""jumbotron p-4 p-md-5 text-white rounded bg-dark"">
        <div class=""col-md-6 px-0"">
            <h1 class=""display-4 font-italic"">About Us: Pelt Of Cheap Stuff</h1>
            <p class=""lead my-3"">
                “Never use the word “cheap”. Today everybody can look chic in inexpensive clothes (the rich buy them too). There is good clothing design on every level today. You can be the chicest thing in the world in a T-shirt and jeans — it’s up to you.”
                <br />― Karl Lagerfeld
            </p>
            <p class=""lead mb-0""><a href=""#"" class=""text-white font-weight-bold"">Continue reading...</a></p>
        </div>
    </div>

    <main role=""main"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to");
                WriteLiteral(@"=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img""><rect width=""100%"" height=""100%"" fill=""#777"" /></svg>
                    <div class=""container"">
                        <div class=""carousel-caption text-left"">
                            <h1>Example headline.</h1>
                            <img class=""img-thumbnail"" src=""https://scontent-iad3-1.xx.fbcdn.net/v/t1.0-9/25552306_1702783603101236_6121077571962933526_n.jpg?_nc_cat=101&_nc_oc=AQl95uujuszHyutN3pg5srTnx3bZfXWj2xeiRtGQKF1uYz-1JI2JsCD0SD9mc_0GYsE&_nc_ht=scontent-iad3-1.xx&oh=5dc20205b4aea80b9c32077daf870844&oe=5E01982E"" />
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id e");
                WriteLiteral(@"lit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img""><rect width=""100%"" height=""100%"" fill=""#777"" /></svg>
                    <div class=""container"">
                        <div class=""carousel-caption"">
                            <h1>Another example headline.</h1>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""bu");
                WriteLiteral(@"tton"">Learn more</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img""><rect width=""100%"" height=""100%"" fill=""#777"" /></svg>
                    <div class=""container"">
                        <div class=""carousel-caption text-right"">
                            <h1>One more for good measure.</h1>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                        </div>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-");
                WriteLiteral(@"prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
        <br />
        <footer>
            <div class=""container"">
                &copy; 2019 - POCS - ");
                EndContext();
                BeginContext(7417, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b45f0d53b1764b7838a2af6fcd96e7c829d3c817072", async() => {
                    BeginContext(7475, 7, true);
                    WriteLiteral("Privacy");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7486, 1685, true);
                WriteLiteral(@"
                <a class=""col-2 "" href=""#"">About Us</a>
                <a class=""col-2 "" href=""#"">Contact Us</a>
                <button class=""float-right""><a href=""#"">Back to top</a></button>
                <p class=""text-dark nav"" style=""font-size: 20px;"">Share us on:</p>
                <a href=""#"" class=""fa fa-facebook "" style=""width: 25px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-twitter "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-instagram "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-youtube "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-reddit-alien "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-pinterest "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-linkedin "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-google "" style=""width: ");
                WriteLiteral(@"30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-vk "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-stack-overflow "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-github "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-dribbble "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-comment "" style=""width: 30px; font-size: 25px;""></a>
                <a href=""#"" class=""fa fa-envelope "" style=""width: 30px; font-size: 25px;""></a>

            </div>
        </footer>
    </main>    
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9178, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
