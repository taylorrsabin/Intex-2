#pragma checksum "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fac3c2e5ab20f49acba9b8a70cd0e5fa2bc98ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/_ViewImports.cshtml"
using IntexII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/_ViewImports.cshtml"
using IntexII.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/_ViewImports.cshtml"
using IntexII.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/_ViewImports.cshtml"
using IntexII.Controllers.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fac3c2e5ab20f49acba9b8a70cd0e5fa2bc98ea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4b4edb30894223eaad3da5828e37da8af2cdae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/tsabinqualtrics.com/Desktop/School/IntexII/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/cookieconsent@3/build/cookieconsent.min.js"" data-cfasync=""false""></script>
<script>
    window.cookieconsent.initialise({
        ""palette"": {
            ""popup"": {
                ""background"": ""#7e7f9a"",
                ""text"": ""#ffffff""
            },
            ""button"": {
                ""background"": ""#353531"",
                ""text"": ""#ffffff""
            }
        },
        ""content"": {
            ""message"": ""This website uses cookies to ensure you get the best experiences on our website. By proceeding, you are consenting to our use of cookies and agreeing to our Privacy Policy"",
            ""dismiss"": ""Got it!"",
            ""href"": ""www.intex.dogetomuchmoon.com/privacypolicy""
        }
    });
</script>
    </script>
<script>
    // Cookie banner
    if (localStorage.getItem('cookieSeen') != 'shown') {
        $("".cookie-banner"").delay(2000).fadeIn();
        localStorage.setItem('cookieSeen', 'shown')
    }

    $('.close').click(function (e) {
        ");
            WriteLiteral(@"$('.cookie-banner').fadeOut();
    });
</script>

<!-- ======= Hero Section ======= -->
<section id=""hero""
         class=""d-flex flex-column justify-content-center align-items-center"">
    <div class=""container text-center text-md-left"" data-aos=""fade-up"">
        <h1>Utah <span>Driving Collision</span></h1>
        <h2>Utah's Department of Motor Vehicles Collision Database</h2>
        <a href=""#about"" class=""btn-get-started scrollto"">Learn More</a>
    </div>
</section>
<!-- End Hero -->

<main id=""main"">
    <!-- ======= What We Do Section ======= -->
    <section id=""what-we-do"" class=""what-we-do"">
        <div class=""container"">
            <div class=""section-title"">
                <h2>What's the number 1 cause of car accidents in Utah?</h2>
                <!-- <p>Magnam dolores commodi suscipit consequatur ex aliquid</p> -->
            </div>

            <div class=""row"">
                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""icon-box"">
         ");
            WriteLiteral("               <div class=\"icon\"><i class=\"bx bx-tachometer\"></i></div>\n                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 2187, "\"", 2194, 0);
            EndWriteAttribute();
            WriteLiteral(@">Speeding</a></h4>
                        <p>
                            In 2016, excessive speed was a factor in 38% of fatal crashes,
                            and speed-related crashes were 2.7 times more likely to be
                            more fatal than others. Speed limits are the law, they are
                            there for a reason.
                        </p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-md-0"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-phone""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 2872, "\"", 2879, 0);
            EndWriteAttribute();
            WriteLiteral(@">Cell Phones</a></h4>
                        <p>
                            Did you know it's illegal to use a cellphone in any way except
                            for GPS apps or hands-free voice talking while driving?
                        </p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-lg-0"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-food-menu""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 3426, "\"", 3433, 0);
            EndWriteAttribute();
            WriteLiteral(@">Distracted Drivers</a></h4>
                        <p>
                            Distracted driving is more than just texting. It includes
                            reading, eating, drinking, talking to passengers, adjusting
                            the temperature controls, and anything else that takes your
                            focus off the road.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End What We Do Section -->
    <!-- ======= About Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <img src=""assets/img/5.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4213, "\"", 4219, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0"">
                    <h3>About Us</h3>
                    <p>
                        Welcome to the Utah Driving Collisions Database. This website was created to help raise awareness of what is happening on Utah roads.
                    </p>
                    <ul>
                        <li>
                            <i class=""bx bx-check-double""></i> Incorporate this data in your research around previous crash data.
                        </li>
                        <li>
                            <i class=""bx bx-check-double""></i> Utilize our prediction calculator to predict crash severity of a future crash.
                        </li>
                    </ul>
                    <div class=""row icon-boxes"">
                        <div class=""col-md-6"">
                            <i class=""bx bx-receipt""></i>
                            <h4>Zero Fatalities</h4>
                            <p>
                    ");
            WriteLiteral(@"            We hope this website helps raise awareness of dangerous driving and pledge to get Utah's roads to have zero fatalities.'
                            </p>
                        </div>
                        <div class=""col-md-6 mt-4 mt-md-0"">
                            <i class=""bx bx-cube-alt""></i>
                            <h4>Predictive Analytics</h4>
                            <p>
                                Our model will help you predict the severity of a car crash on Utah roads. Take this as a reminder to always stay cautious and aware while driving.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End About Section -->
    <!-- ======= Skills Section ======= -->
    <section id=""skills"" class=""skills"">
        <div class=""container"">
            <div class=""row skills-content"">
                <h3>Crash Information for 2021</h3>
                <div class=""co");
            WriteLiteral(@"l-lg-6"">
                    <div class=""progress"">
                        <span class=""skill"">No injury <i class=""val"">70.22%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""70.22""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">Possible injury <i class=""val"">15.96%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""15.96""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
   ");
            WriteLiteral(@"                 </div>

                    <div class=""progress"">
                        <span class=""skill"">Suspected minor injury <i class=""val"">11.03%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""11.03""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-6"">
                    <div class=""progress"">
                        <span class=""skill"">Serious injury <i class=""val"">2.31%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""2.31""
                                 aria-valuemin=""0""
      ");
            WriteLiteral(@"                           aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">Fatal <i class=""val"">.48%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow="".48""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
    </section>
    <!-- End Skills Section -->
    <!-- ======= Counts Section ======= -->
    <section id=""counts"" class=""counts"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-6"">
                    <div class=""count-box"">
                        <i class=""bi bi-people"">");
            WriteLiteral(@"</i>
                        <span data-purecounter-start=""0""
                              data-purecounter-end=""61247""
                              data-purecounter-duration=""1""
                              class=""purecounter""></span>
                        <p>Total Crash Count</p>
                    </div>
                </div>

                <div class=""col-lg-3 col-6"">
                    <div class=""count-box"">
                        <i class=""bi bi-people""></i>
                        <span data-purecounter-start=""0""
                              data-purecounter-end=""43007""
                              data-purecounter-duration=""1""
                              class=""purecounter""></span>
                        <p>Total Property Damage Only Crash Count</p>
                    </div>
                </div>

                <div class=""col-lg-3 col-6 mt-5 mt-lg-0"">
                    <div class=""count-box"">
                        <i class=""bi bi-people""></i>
                        <span dat");
            WriteLiteral(@"a-purecounter-start=""0""
                              data-purecounter-end=""17946""
                              data-purecounter-duration=""1""
                              class=""purecounter""></span>
                        <p>Total Injury Crash Count</p>
                    </div>
                </div>

                <div class=""col-lg-3 col-6 mt-5 mt-lg-0"">
                    <div class=""count-box"">
                        <i class=""bi bi-people""></i>
                        <span data-purecounter-start=""0""
                              data-purecounter-end=""294""
                              data-purecounter-duration=""1""
                              class=""purecounter""></span>
                        <p>Total Fatal Crash Count</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End Counts Section -->
    <!-- ======= Footer ======= -->

    <footer>
        <div class=""container d-md-flex py-4"">
            <div class=""me-md-auto text-center");
            WriteLiteral(" text-md-start\">\n\n            </div>\n\n        </div>\n    </footer>\n    <!-- End Footer -->\n\n    <a href=\"#\"\n       class=\"back-to-top d-flex align-items-center justify-content-center\">\n        <i class=\"bi bi-arrow-up-short\"></i>\n    </a>\n\n\n</main>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
