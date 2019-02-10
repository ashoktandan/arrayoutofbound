#pragma checksum "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b1f9ce46462a8a2f6839baff5c9c222ec6029f"
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
#line 1 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/_ViewImports.cshtml"
using Testmvc;

#line default
#line hidden
#line 2 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/_ViewImports.cshtml"
using Testmvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b1f9ce46462a8a2f6839baff5c9c222ec6029f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1435c9fdf82754e73620e5d155a91890efca497c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
  
    int counter = 5;

#line default
#line hidden
            BeginContext(76, 168, true);
            WriteLiteral("<div class=\"\">\r\n    <div class=\"row flex-center\">\r\n        <div class=\"col-8 col\">\r\n                <h3>Popular this week:</h3>\r\n                <div class=\"cards\">\r\n\r\n");
            EndContext();
#line 14 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                     foreach (var post in (Model as IEnumerable<Post>).Take(5).Reverse())
    {

#line default
#line hidden
            BeginContext(342, 50, true);
            WriteLiteral("                <div class=\"cardWrapper\" data-id=\"");
            EndContext();
            BeginContext(393, 7, false);
#line 16 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                             Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(400, 83, true);
            WriteLiteral("\">\r\n                    <div class=\"card cardheight\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 483, "\"", 507, 1);
#line 18 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 489, post.PostImageURL, 489, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(508, 194, true);
            WriteLiteral(" alt=\"Card example image\">\r\n\r\n                        <div class=\"card-body\">\r\n                            <div class=\"trends\">\r\n                                <h4 class=\"card-title uppercase\">");
            EndContext();
            BeginContext(703, 7, false);
#line 22 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                            Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(710, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(713, 14, false);
#line 22 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                                      Write(post.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(727, 73, true);
            WriteLiteral("</h4>\r\n                                <h5 class=\"card-subtitle capital\">");
            EndContext();
            BeginContext(801, 17, false);
#line 23 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                             Write(post.PostSubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(818, 60, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
            EndContext();
            BeginContext(879, 27, false);
#line 24 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                Write(Html.Raw(@post.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(906, 161, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row margin-top margin-bottom-none\">\r\n                                <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1067, "\"", 1100, 2);
            WriteAttributeValue("", 1074, "/Home/post?postid=", 1074, 18, true);
#line 27 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 1092, post.Id, 1092, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1101, 96, true);
            WriteLiteral(">more ...</a></button>\r\n                                <p class=\"margin-left-large\">Posted on: ");
            EndContext();
            BeginContext(1198, 38, false);
#line 28 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                                   Write(post.PostCreatedOn.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1236, 130, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        </div>\r\n                </div>\r\n");
            EndContext();
#line 33 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                        counter--;
                    }

#line default
#line hidden
            BeginContext(1425, 105, true);
            WriteLiteral("                </div>\r\n\r\n\r\n            <h3>Recent Posts:</h3>\r\n            <div id=\"articleContainer\">\r\n");
            EndContext();
#line 40 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                 foreach (var post in Model)
    {

#line default
#line hidden
            BeginContext(1583, 241, true);
            WriteLiteral("                <article class=\"article border margin-bottom-small padding\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col col-6\">\r\n                            <h3 class=\"article-title uppercase\"><a href=\"\">");
            EndContext();
            BeginContext(1825, 14, false);
#line 45 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                                      Write(post.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1839, 72, true);
            WriteLiteral("</a></h3>\r\n                            <h5 class=\"article-meta capital\">");
            EndContext();
            BeginContext(1912, 17, false);
#line 46 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                        Write(post.PostSubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 152, true);
            WriteLiteral("</h5>\r\n                            <p class=\"article-meta\">Written by <a href=\"#\">Super User</a></p>\r\n                            <p class=\"text-lead\"> ");
            EndContext();
            BeginContext(2082, 27, false);
#line 48 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                             Write(Html.Raw(@post.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 48, true);
            WriteLiteral("</p>\r\n                            <p>Posted on: ");
            EndContext();
            BeginContext(2158, 38, false);
#line 49 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                     Write(post.PostCreatedOn.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2196, 121, true);
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                        <div class=\"col col-6\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2317, "\"", 2341, 1);
#line 53 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 2323, post.PostImageURL, 2323, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2342, 137, true);
            WriteLiteral(" alt=\"Card example image\">\r\n                            <div class=\"row margin-large\">\r\n                                <button data-id=\"");
            EndContext();
            BeginContext(2480, 7, false);
#line 55 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                            Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2487, 4, true);
            WriteLiteral("\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2491, "\"", 2526, 2);
            WriteAttributeValue("", 2498, "/Home/delete?postid=", 2498, 20, true);
#line 55 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 2518, post.Id, 2518, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2527, 71, true);
            WriteLiteral(">delete</a></button>\r\n                                <button data-id=\"");
            EndContext();
            BeginContext(2599, 7, false);
#line 56 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                            Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2606, 4, true);
            WriteLiteral("\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2610, "\"", 2643, 2);
            WriteAttributeValue("", 2617, "/Home/post?postid=", 2617, 18, true);
#line 56 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 2635, post.Id, 2635, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2644, 194, true);
            WriteLiteral(">Read More</a></button>\r\n                                <button>5 Comments</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n</article>\r\n");
            EndContext();
#line 62 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"

}

#line default
#line hidden
            BeginContext(2843, 125, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-4 col child-borders\">\r\n            <h3>Trending Posts:</h3>\r\n");
            EndContext();
#line 70 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
             foreach (var post in ViewBag.top5posts as IEnumerable<Post>)
    {

#line default
#line hidden
            BeginContext(3050, 188, true);
            WriteLiteral("        <div class=\"card\" style=\"width: 100%;margin:5px;\">\r\n            <div class=\"card-body\">\r\n                <div class=\"trends\">\r\n                    <h4 class=\"card-title uppercase\">");
            EndContext();
            BeginContext(3239, 14, false);
#line 75 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                Write(post.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3253, 61, true);
            WriteLiteral("</h4>\r\n                    <h5 class=\"card-subtitle capital\">");
            EndContext();
            BeginContext(3315, 17, false);
#line 76 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                 Write(post.PostSubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 48, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(3381, 27, false);
#line 77 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                    Write(Html.Raw(@post.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(3408, 114, true);
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"row margin-top-large\">\r\n                    <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3522, "\"", 3555, 2);
            WriteAttributeValue("", 3529, "/Home/post?postid=", 3529, 18, true);
#line 81 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 3547, post.Id, 3547, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3556, 88, true);
            WriteLiteral(">Read More...</a></button>\r\n                    <p class=\"margin-left-large\">Posted on: ");
            EndContext();
            BeginContext(3645, 38, false);
#line 82 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
                                                       Write(post.PostCreatedOn.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3683, 66, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 86 "/Users/ashoktandan/Projects/Testmvc/Testmvc/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(3752, 42, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n</div>\r\n");
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
