#pragma checksum "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5df0a8e80c2f9aa9f8548fddcfeb4c7322ee830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(per.Pages.Pages_BlogPost), @"mvc.1.0.razor-page", @"/Pages/BlogPost.cshtml")]
namespace per.Pages
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
#line 1 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\_ViewImports.cshtml"
using per;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/blog/{slug}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5df0a8e80c2f9aa9f8548fddcfeb4c7322ee830", @"/Pages/BlogPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f97c454c63809a9e4167ae5a0ee0b0087532df4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BlogPost : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profile-picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mh-100 mw-100 rounded-circle my-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/profilePic.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
  
    var blogPostObj = await Model.GetPostObj();

    var blogPost = blogPostObj.Content.BlogPost;

    var markdownBody = await Model.GetMarkdown();

    var singlePostVideo = blogPost.Video.EmbeddedAddress;

    var postDateTime = blogPost.PostDate.Value;

    string singleDate = postDateTime.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

    var markdown = blogPostObj.Content.MarkdownBodyPart.Markdown;

    var imagePaths = blogPost.Media.Paths;
    int count = imagePaths.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"page-section bg-primary\">\r\n    <div class=\"container white-text\">\r\n        <div class=\"card card-background p-3 mb-5\">\r\n\r\n            <h2 class=\"text-center mb-5\">");
#nullable restore
#line 31 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                                    Write(blogPostObj.DisplayText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
             if (count > 0)
            {
                string imagePath = blogPost.Media.Paths[0];


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row justify-content-center mb-5\">\r\n                    <div class=\"col-12 col-lg-10\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1104, "\"", 1138, 1);
#nullable restore
#line 39 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
WriteAttributeValue("", 1110, Orchard.AssetUrl(imagePath), 1110, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mh-100 mw-100\" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
             if (singlePostVideo != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row justify-content-center mb-5"">
                    <div class=""col-12 col-md-10"">
                        <div class=""embed-responsive embed-responsive-16by9"">
                            <iframe scrolling=""no"" type=""text/html""");
            BeginWriteAttribute("src", " src=\"", 1554, "\"", 1638, 2);
#nullable restore
#line 49 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
WriteAttributeValue("", 1560, blogPost.Video.EmbeddedAddress, 1560, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1593, "?rel=0&cc_load_policy=1&iv_load_policy=3&fs=0", 1593, 45, true);
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\"></iframe>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
             if (markdown != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"blog-content\" class=\"text-justify mb-5\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
               Write(markdownBody);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 60 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- Social Sharing -->

            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""text-center col-4 col-sm-3 col-md-2 col-lg-2 pr-lg-0 pl-lg-0 mb-2 ml-lg-n5"">
                        <div class=""fb-share-button"" data-href=""http://pedroeloyrdz.com/blog/");
#nullable restore
#line 67 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                                                                                        Write(blogPostObj.Content.AliasPart.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-layout=""button"" data-size=""small""><a target=""_blank"" href=""https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fdevelopers.facebook.com%2Fdocs%2Fplugins%2F&amp;src=sdkpreparse"" class=""fb-xfbml-parse-ignore"">Compartir</a></div>
                    </div>
                    <div class=""text-center col-4 col-sm-3 col-md-2 col-lg-1 top-padding pt-md-1 pl-lg-0 pr-lg-2 pr-xl-5 pr-0 mb-2"">
                        <a class=""twitter-share-button""");
            BeginWriteAttribute("href", "\r\n                           href=\"", 2793, "\"", 2893, 2);
            WriteAttributeValue("", 2828, "http://pedroeloyrdz.com/blog/", 2828, 29, true);
#nullable restore
#line 71 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
WriteAttributeValue("", 2857, blogPostObj.Content.AliasPart.Alias, 2857, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            Tweet
                        </a>
                    </div>
                    <div class=""text-center col-4 col-sm-3 col-md-2 col-lg-1 mb-2"">
                        <script type=""IN/Share"" data-url=""http://pedroeloyrdz.com/blog/");
#nullable restore
#line 76 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                                                                                  Write(blogPostObj.Content.AliasPart.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        </script>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""about"" class=""page-section bg-white py-5"">
    <div class=""container justify-content-center"">
        <div class=""row"">
            <div class=""col-6 col-sm-3 col-lg-2 align-items-start align-items-md-center mb-2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5df0a8e80c2f9aa9f8548fddcfeb4c7322ee83011395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-11 col-sm-8\">\r\n                <div class=\"row\">\r\n                    <div id=\"date\" class=\"container w-100 ml-2\">\r\n                        <p class=\"date-text d-inline\">Post por Pedro Eloy Rodríguez</p>\r\n");
#nullable restore
#line 95 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                         if (postDateTime != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-calendar-alt d-inline date-text ml-2\"></i>\r\n                                <p class=\"date-text d-inline\">");
#nullable restore
#line 98 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                                                         Write(singleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 99 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""row"">
                    <h1 class=""w-100"" id=""about-him"">Acerca de Pedro Eloy</h1>
                </div>
                <div class=""row"">
                    <p id=""about-text"" class=""w-100 text-justify mx-1"">
                        Pedro es fundador de Grupo Percepciones, speaker internacional y consultor de empresas en temas de: Experiencia del Cliente, Metodología de Ventas y Productividad Personal. Ha sido nombrado Líder Inspirador del Siglo XXI por la Global Quality Foundation y recibió el reconocimiento a la Excelencia Profesional por a UANL. Ha participado en la reconocida plataforma de TEDx y es actualmente colaborador de Imagen Televisión, y uno de los conferencistas de mayor impacto en México.
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>

");
#nullable restore
#line 115 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
Write(Orchard.ConsoleLog(blogPostObj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\enigm\source\repos\GrupoPercepciones\per\per\Pages\BlogPost.cshtml"
 
    [FromRoute]
    public string Slug { get; set; }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.IOrchardHelper Orchard { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogPostModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogPostModel>)PageContext?.ViewData;
        public BlogPostModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
