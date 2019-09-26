<%@ Page Title="" Language="C#" MasterPageFile="~/PizzeriaMP/Pizzeria.Master" AutoEventWireup="true" CodeBehind="Bienvenida.aspx.cs" Inherits="Pizzeria.GUI.Bienvenida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Inicio" ContentPlaceHolderID="inicio" runat="server">
    <!-- Home Content Section -->
    <div class="home">
        <!-- Home Slider Banner -->
        <div class="home-banner">

            <div class="tp-banner-container" style="overflow: visible;">
                <div class="tp-banner revslider-initialised tp-simpleresponsive hovered" id="revslider-619" style="max-height: 700px; height: 604px;">
                    <%--<ul class="tp-revslider-mainul" style="display: block; overflow: hidden; width: 100%; height: 100%; max-height: none;">--%>
                        <!-- SLIDE  -->
                        <%--<li data-transition="slidevertical" data-slotamount="1" data-masterspeed="1000" data-thumb="../PizzeriaMP/MasterPage/img/IMG_9863.jpg" data-saveperformance="off" data-title="Slide" class="tp-revslider-slidesli active-revslide current-sr-slide-visible" style="width: 100%; height: 100%; overflow: hidden; z-index: 20; visibility: inherit; opacity: 1;">--%>
                            <!-- MAIN IMAGE -->
                            <div class="slotholder" style="width: 100%; height: 100%;" data-duration="undefined" 
                                data-zoomstart="undefined" data-zoomend="undefined" data-rotationstart="undefined" 
                                data-rotationend="undefined" data-ease="undefined" data-bgpositionend="undefined" 
                                data-bgposition="center top" data-kenburns="undefined" data-easeme="undefined" 
                                data-bgfit="cover" data-bgfitend="undefined" data-owidth="undefined" 
                                data-oheight="undefined">
                                <div class="tp-bgimg defaultimg" data-lazyload="undefined" data-bgfit="cover" 
                                    data-bgposition="center top" data-bgrepeat="no-repeat" data-lazydone="undefined" 
                                    src="../PizzeriaMP/MasterPage/img/PizzeriaBalboa2.jpg" 
                                    data-src="../PizzeriaMP/MasterPage/PizzeriaBalboa2.jpg" 
                                    style="background-color: rgba(0, 0, 0, 0); background-repeat: no-repeat; background-image: url(&quot;../PizzeriaMP/MasterPage/img/PizzeriaBalboa2.jpg&quot;); background-size: cover; background-position: center top; width: 100%; height: 100%; opacity: 1; visibility: inherit;">
                                </div>
                            </div>
                            <!-- LAYERS -->
                            
                            <!-- LAYER NR. 1 -->
                            <div class="tp-caption light_heavy_70_shadowed lfb ltt tp-resizeme start" data-x="center" 
                                data-hoffset="0" data-y="center" data-voffset="-40" data-speed="600" data-start="800" 
                                data-easing="Power4.easeOut" data-splitin="none" data-splitout="none" 
                                data-elementdelay="0.01" data-endelementdelay="0.1" data-endspeed="500" 
                                data-endeasing="Power4.easeIn" 
                                style="z-index: 2; white-space: nowrap; left: 332px; top: 177.342px; visibility: visible; opacity: 1; transform: matrix3d(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, -0.0025, 0, 0, 0, 1);">
                                <img src="../PizzeriaMP/MasterPage/img/DLIZIA_logo3.png" width="400" height="196" class="responsive-img" alt=" " style="width: 344.957px; height: 169.029px;"/>
                            </div>

                            <!-- LAYER NR. 2 -->
                            <div class="tp-caption light_medium_30_shadowed lfb ltt tp-resizeme start animated fadeInUp" 
                                style="z-index: 3; white-space:nowrap; transition: all 0s ease 0s; min-height: 0px; min-width: 0px; line-height: 34px; border-width: 0px; margin: 0px; padding: 0px; letter-spacing: 0px; font-size: 26px; left: 335.5px; top: 362.453px; visibility: visible; opacity: 1; transform: matrix3d(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, -0.0025, 0, 0, 0, 1);">
                                <h4 class="white-text" style="font-weight:bold">¡¡¡ Bienvenido a D`lizia !!!</h4>
                            </div>
                        <%--</li>--%>
                    <%--</ul>--%>
                    <div class="tp-bannertimer" style="width: 75.3222%; visibility: visible; transform: translate3d(0px, 0px, 0px);"></div>
                    <div class="tp-loader spinner0" style="display: none;">
                        <div class="dot1"></div>
                        <div class="dot2"></div>
                        <div class="bounce1"></div>
                        <div class="bounce2"></div>
                        <div class="bounce3"></div>
                    </div>
                </div>
            </div>

            <!-- Home Bottom Section -->

            <div class="down-circle">
                <div class="home-scroll-content">
                    Desubre más...   
                </div>
                <div data-wow-delay="2s" class="span3 wow fadeInLeftBig animated" style="visibility: visible; animation-delay: 2s; animation-name: fadeInLeftBig;">
                    <div class="anchor nextLink">
                        <div class="wow bounce animated" data-wow-delay="3s" data-wow-iteration="1" data-wow-duration="1s" style="visibility: visible; animation-duration: 1s; animation-delay: 3s; animation-iteration-count: 1; animation-name: bounce;">
                            <a href="#about" class="btn-floating waves-effect waves-light btn-large white smoothscroll">
                                <i class="fa fa-arrow-down"></i></a>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Home Bottom Section -->
        </div>
        </div>
        <!-- // Home Slider Banner --

        <div class="colorbg">
            <div class="container">
                <h1>A casual fine dining restaurant</h1>
                <p>offering American cuisine and warm hospitality in a rustic historically preserved building.</p>
            </div>
        </div>
    </div>
    <!-- Home Content Section -->

    <!-- About Section -->

    <div id="about" class="whitebg scrollspy">
        <div class="row container">
            <div id="accordion" class="section scrollspy">
                <div class="row">

                    <!-- Left Section -->
                    <div class="col l6 s12">
                        <div class="clearfix">

                            <div class="col s12 l6 marbot30">
                                <div class="material-placeholder">
                                    <img data-wow-delay="0.1s" class="responsive-img materialboxed span3 wow flipInY z-depth-4 intialized animated" data-caption="A picture of some deer and tons of trees" src="../PizzeriaMP/MasterPage/img/Vaso.png" alt=" " style="visibility: visible; animation-delay: 0.1s; animation-name: flipInY;"/></div>
                            </div>


                            <div class="col s12 l6 marbot30">
                                <div class="material-placeholder">
                                    <img data-wow-delay="0.1s" class="responsive-img materialboxed span3 wow flipInY z-depth-4 intialized animated" data-caption="A picture of some deer and tons of trees" src="../PizzeriaMP/MasterPage/img/SalsaDeTomate.png" alt=" " style="visibility: visible; animation-delay: 0.1s; animation-name: flipInY;"/></div>
                            </div>

                            <div class="col s12 l6 marbot30">
                                <div class="material-placeholder">
                                    <img data-wow-delay="0.1s" class="responsive-img materialboxed span3 wow flipInY z-depth-4 intialized animated" data-caption="A picture of some deer and tons of trees" src="../PizzeriaMP/MasterPage/img/pan.png" alt=" " style="visibility: visible; animation-delay: 0.1s; animation-name: flipInY;"/></div>
                            </div>

                            <div class="col s12 l6 marbot30">
                                <div class="material-placeholder">
                                    <img data-wow-delay="0.1s" class="responsive-img materialboxed span3 wow flipInY z-depth-4 intialized animated" data-caption="A picture of some deer and tons of trees" src="../PizzeriaMP/MasterPage/img/CopasVino.png" alt=" " style="visibility: visible; animation-delay: 0.1s; animation-name: flipInY;"/></div>
                            </div>

                        </div>
                    </div>
                    <!-- Left Section -->

                    <!-- Right Section -->
                    <div class="col l6 s12">
                        <div class="center">
                            <h1 class="marbot15 wow fadeInUp animated animated" data-wow-delay="300ms" style="visibility: visible; animation-delay: 300ms; animation-name: fadeInUp;">Material is a casual fine dining restaurant</h1>
                            <div class="hr-line"><i class="mdi-action-star-rate"></i></div>
                            <div class="tag padding-12-per">
                                Specializes in Non-veg, 65, Thanthuri, Sandwich, 65 smoked sandwich. Freshly prepared with the best ingredients, for those who live to eat not eat to live.
               
                            </div>
                        </div>

                        <ul class="collapsible martop30" data-collapsible="accordion">
                            <li class="">
                                <div class="collapsible-header">Our Private Dining
                                    <i class="fa fa-arrow-circle-down"></i></div>
                                <div class="collapsible-body" style="">
                                    <p>Our menus are packed with Mexican and American dishes to suit all tastes and freshly prepared with the best ingredients For those who live to eat not eat to live.</p>
                                </div>
                            </li>
                            <li class="">
                                <div class="collapsible-header">Parking Facilitis<i class="mdi-hardware-keyboard-arrow-down"></i></div>
                                <div class="collapsible-body" style="">
                                    <p>Free Car Parking / 2 wheeler is available for customers lorum ipsum dollar consectetur adi pisi cing elit, sed do eiusmod tempor exercitationem .</p>
                                </div>
                            </li>
                            <li class="">
                                <div class="collapsible-header">Number Of Seats <i class="mdi-hardware-keyboard-arrow-down"></i></div>
                                <div class="collapsible-body" style="">
                                    <p>24 seats included private room for 4 persons.</p>
                                </div>
                            </li>
                            <li>
                                <div class="collapsible-header">Credit Cards &amp; Dress Code <i class="mdi-hardware-keyboard-arrow-down"></i></div>
                                <div class="collapsible-body" style="">
                                    <p>VISA / MASTER/ JCB / American Express / Diners</p>
                                    <p>No T-shirts, half pants/only male, sandals/only male. Appropriate clothing and footwear is always required in all areas at all times. Men wearing backless sandals are not permitted.</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- Right Section -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
