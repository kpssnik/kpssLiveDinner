#pragma checksum "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc74adff787553497d51a27c293b8697b109f238"
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
#line 1 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc74adff787553497d51a27c293b8697b109f238", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c064d63c831746c8eac0d60cdb522b91804af59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Start slides -->\r\n    <div id=\"slides\" class=\"cover-slides\">\r\n        <ul class=\"slides-container\">\r\n            <li class=\"text-left\">\r\n                <img src=\"images/slider-01.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 236, "\"", 242, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <h1 class=""m-b-20""><strong>Welcome To <br> Live Dinner Restaurant</strong></h1>
                            <p class=""m-b-40"">
                                See how your users experience your website in realtime or view  <br>
                                trends to see any changes in performance over time.
                            </p>
                            <p><a class=""btn btn-lg btn-circle btn-outline-new-white"" href=""#"">Reservation</a></p>
                        </div>
                    </div>
                </div>
            </li>
            <li class=""text-left"">
                <img src=""images/slider-02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1055, "\"", 1061, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <h1 class=""m-b-20""><strong>Welcome To <br> Live Dinner Restaurant</strong></h1>
                            <p class=""m-b-40"">
                                See how your users experience your website in realtime or view  <br>
                                trends to see any changes in performance over time.
                            </p>
                            <p><a class=""btn btn-lg btn-circle btn-outline-new-white"" href=""#"">Reservation</a></p>
                        </div>
                    </div>
                </div>
            </li>
            <li class=""text-left"">
                <img src=""images/slider-03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1874, "\"", 1880, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <h1 class=""m-b-20""><strong>Welcome To <br> Yamifood Restaurant</strong></h1>
                            <p class=""m-b-40"">
                                See how your users experience your website in realtime or view  <br>
                                trends to see any changes in performance over time.
                            </p>
                            <p><a class=""btn btn-lg btn-circle btn-outline-new-white"" href=""#"">Reservation</a></p>
                        </div>
                    </div>
                </div>
            </li>
        </ul>
        <div class=""slides-navigation"">
            <a href=""#"" class=""next""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></a>
            <a href=""#"" class=""prev""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></a>
        </div>
    </div>
    <!-- End slides -->
");
            WriteLiteral(@"    <!-- Start About -->
    <div class=""about-section-box"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6 col-sm-12 text-center"">
                    <div class=""inner-column"">
                        <h1>Welcome To <span>Live Dinner Restaurant</span></h1>
                        <h4>Little Story</h4>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque auctor suscipit feugiat. Ut at pellentesque ante, sed convallis arcu. Nullam facilisis, eros in eleifend luctus, odio ante sodales augue, eget lacinia lectus erat et sem. </p>
                        <p>Sed semper orci sit amet porta placerat. Etiam quis finibus eros. Sed aliquam metus lorem, a pellentesque tellus pretium a. Nulla placerat elit in justo vestibulum, et maximus sem pulvinar.</p>
                        <a class=""btn btn-lg btn-circle btn-outline-new-white"" href=""#"">Reservation</a>
                    </div>
                </div");
            WriteLiteral(">\r\n                <div class=\"col-lg-6 col-md-6 col-sm-12\">\r\n                    <img src=\"images/about-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4042, "\"", 4048, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                </div>
            </div>
        </div>
    </div>
    <!-- End About -->
    <!-- Start QT -->
    <div class=""qt-box qt-background"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto text-center"">
                    <p class=""lead "">
                        "" If you're not the one cooking, stay out of the way and compliment the chef. ""
                    </p>
                    <span class=""lead"">Michael Strahan</span>
                </div>
            </div>
        </div>
    </div>
    <!-- End QT -->
    <!-- Start Menu -->
    <div class=""menu-box"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""heading-title text-center"">
                        <h2>Special Menu</h2>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting</p>
                    </d");
            WriteLiteral(@"iv>
                </div>
            </div>

            <div class=""row inner-menu-box"">
                <div class=""col-3"">
                    <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                        <a class=""nav-link active"" id=""v-pills-home-tab"" data-toggle=""pill"" href=""#v-pills-home"" role=""tab"" aria-controls=""v-pills-home"" aria-selected=""true"">All</a>
                        <a class=""nav-link"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab"" aria-controls=""v-pills-profile"" aria-selected=""false"">Drinks</a>
                        <a class=""nav-link"" id=""v-pills-messages-tab"" data-toggle=""pill"" href=""#v-pills-messages"" role=""tab"" aria-controls=""v-pills-messages"" aria-selected=""false"">Lunch</</a>
                        <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">Dinner</a>
            ");
            WriteLiteral(@"        </div>
                </div>

                <div class=""col-9"">
                    <div class=""tab-content"" id=""v-pills-tabContent"">
                        <div class=""tab-pane fade show active"" id=""v-pills-home"" role=""tabpanel"" aria-labelledby=""v-pills-home-tab"">
                            <div class=""row"">
                                <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-01.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Drinks 1</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $7.79</h5>
                                        </div>
                                    </div>
                                </div>

             ");
            WriteLiteral(@"                   <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-02.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Drinks 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $9.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-03.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                     ");
            WriteLiteral(@"       <h4>Special Drinks 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $10.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-04.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Lunch 1</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $15.79</h5>
                                        </div>
                                    </div>
                                </div>

                     ");
            WriteLiteral(@"           <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-05.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Lunch 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $18.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-06.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4");
            WriteLiteral(@">Special Lunch 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $20.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-07.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Dinner 1</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $25.79</h5>
                                        </div>
                                    </div>
                                </div>

                              ");
            WriteLiteral(@"  <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-08.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Dinner 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $22.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-09.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Speci");
            WriteLiteral(@"al Dinner 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $24.79</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
                            <div class=""row"">
                                <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-01.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Drinks 1</h4>
                                            <p>Sed id magna vitae eros sagittis eu");
            WriteLiteral(@"ismod.</p>
                                            <h5> $7.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-02.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Drinks 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $9.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid drinks"">
                                    <div class=""gall");
            WriteLiteral(@"ery-single fix"">
                                        <img src=""images/img-03.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Drinks 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $10.79</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-messages"" role=""tabpanel"" aria-labelledby=""v-pills-messages-tab"">
                            <div class=""row"">
                                <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-04.jpg"" class=""img-f");
            WriteLiteral(@"luid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Lunch 1</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $15.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-05.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Lunch 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $18.79</h5>
                                   ");
            WriteLiteral(@"     </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid lunch"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-06.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Lunch 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $20.79</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-settings"" role=""tabpanel"" aria-labelledby=""v-pills-settings-tab"">
                            <div class=""row"">
   ");
            WriteLiteral(@"                             <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-07.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Dinner 1</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $25.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-08.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                          ");
            WriteLiteral(@"                  <h4>Special Dinner 2</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $22.79</h5>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-lg-4 col-md-6 special-grid dinner"">
                                    <div class=""gallery-single fix"">
                                        <img src=""images/img-09.jpg"" class=""img-fluid"" alt=""Image"">
                                        <div class=""why-text"">
                                            <h4>Special Dinner 3</h4>
                                            <p>Sed id magna vitae eros sagittis euismod.</p>
                                            <h5> $24.79</h5>
                                        </div>
                                    </div>
                                </div>
          ");
            WriteLiteral(@"                  </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <!-- End Menu -->
    <!-- Start Gallery -->
    <div class=""gallery-box"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""heading-title text-center"">
                        <h2>Gallery</h2>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting</p>
                    </div>
                </div>
            </div>
            <div class=""tz-gallery"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-01.jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-01.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                    <div c");
            WriteLiteral(@"lass=""col-sm-6 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-02.jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-02.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                    <div class=""col-sm-6 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-03.jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-03.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                    <div class=""col-sm-12 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-04.jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-04.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                    <div class=""col-sm-6 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-05.");
            WriteLiteral(@"jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-05.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                    <div class=""col-sm-6 col-md-4 col-lg-4"">
                        <a class=""lightbox"" href=""images/gallery-img-06.jpg"">
                            <img class=""img-fluid"" src=""images/gallery-img-06.jpg"" alt=""Gallery Images"">
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Gallery -->
    <!-- Start Customer Reviews -->
    <div class=""customer-reviews-box"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""heading-title text-center"">
                        <h2>Customer Reviews</h2>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting</p>
                    </div>
                </div>
       ");
            WriteLiteral(@"     </div>
            <div class=""row"">
                <div class=""col-md-8 mr-auto ml-auto text-center"">
                    <div id=""reviews"" class=""carousel slide"" data-ride=""carousel"">
                        <div class=""carousel-inner mt-4"">
                            <div class=""carousel-item text-center active"">
                                <div class=""img-box p-1 border rounded-circle m-auto"">
                                    <img class=""d-block w-100 rounded-circle"" src=""images/quotations-button.png""");
            BeginWriteAttribute("alt", " alt=\"", 23012, "\"", 23018, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <h5 class=""mt-4 mb-0""><strong class=""text-warning text-uppercase"">Paul Mitchel</strong></h5>
                                <h6 class=""text-dark m-0"">Web Developer</h6>
                                <p class=""m-0 pt-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.</p>
                            </div>
                            <div class=""carousel-item text-center"">
                                <div class=""img-box p-1 border rounded-circle m-auto"">
                                    <img class=""d-block w-100 rounded-circle"" src=""images/quotations-button.png""");
            BeginWriteAttribute("alt", " alt=\"", 23877, "\"", 23883, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <h5 class=""mt-4 mb-0""><strong class=""text-warning text-uppercase"">Steve Fonsi</strong></h5>
                                <h6 class=""text-dark m-0"">Web Designer</h6>
                                <p class=""m-0 pt-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.</p>
                            </div>
                            <div class=""carousel-item text-center"">
                                <div class=""img-box p-1 border rounded-circle m-auto"">
                                    <img class=""d-block w-100 rounded-circle"" src=""images/quotations-button.png""");
            BeginWriteAttribute("alt", " alt=\"", 24740, "\"", 24746, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <h5 class=""mt-4 mb-0""><strong class=""text-warning text-uppercase"">Daniel vebar</strong></h5>
                                <h6 class=""text-dark m-0"">Seo Analyst</h6>
                                <p class=""m-0 pt-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.</p>
                            </div>
                        </div>
                        <a class=""carousel-control-prev"" href=""#reviews"" role=""button"" data-slide=""prev"">
                            <i class=""fa fa-angle-left"" aria-hidden=""true""></i>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#reviews"" role=""button"" data-slide=""next"">
             ");
            WriteLiteral(@"               <i class=""fa fa-angle-right"" aria-hidden=""true""></i>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Customer Reviews -->
");
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
