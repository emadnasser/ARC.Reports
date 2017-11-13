<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" EnableViewState="false"  Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>DevExpress Bootstrap Controls for ASP.NET Demos</title>
    <link rel="stylesheet" type="text/css" href="Content/Default/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="Content/landing.css" />
    <link rel="stylesheet" type="text/css" href="Content/FontAwesome/font-awesome.min.css" />
</head>
<body>
    <div class="header">
        <div class="header-content">
            <h1>DevExpress Bootstrap Controls</h1>
            <h4>The power and simplicity of server-side ASP.NET WebForms Controls, combined with the client-side responsiveness and render code clarity of Bootstrap framework, bringing you the best of two worlds.</h4>
            <br />
            <a runat="server" ID="StartBtn" href="<%# DemoUtils.StartDemoUrl %>" class="btn btn-demos btn-lg">Try Demos</a>
        </div>
    </div>
    <div class="content container">
        <div class="row">
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-cog"></span>
                <h3>Bootstrap-Enabled</h3>
                <p class="text-muted">These controls natively integrate into Bootstrap-driven layouts thus contributing to the application’s adaptivity and consistent look across browsers and devices.</p>
            </div>
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-columns"></span>
                <h3>Adaptive by Design</h3>
                <p class="text-muted">Our rendered code uses Bootstrap CSS components exclusively, meaning that all controls will adjust to any screen resolution. Simply follow Bootstrap guidelines, and you are guaranteed to achieve application-level adaptivity.</p>
            </div>
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-mobile"></span>
                <h3>Mobile-Friendly</h3>
                <p class="text-muted">With lightweight render, responsive layout, and performance approaching native controls, you can be sure to extend your site’s audience reach and boost search rankings.</p>
            </div>
        
            <div class="clearfix visible-lg-block"></div>                
        
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-paint-brush"></span>
                <h3>Visually Consistent</h3>
                <p class="text-muted">Focus on business and stop wasting cycles on design. Leave it to Bootstrap’s myriad of available visual themes to guarantee consistent look and feel throughout your web application – from early prototype to production.</p>
            </div>
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-briefcase"></span>
                <h3>An Extensive Control Suite</h3>
                <p class="text-muted">The DevExpress Bootstrap Control Suite includes a GridView with powerful data analysis and display features, Data Editors with automatic layout management, and Navigation Controls.</p>
            </div>
            <div class="col-lg-4 col-md-6 text-center">
                <span class="fa fa-thumbs-up"></span>
                <h3>Powered by ASP.NET Controls</h3>
                <p class="text-muted">New render comes with familiar feature set. Expect the same level of server-side and client-side API as in DevExpress ASP.NET WebForms Controls. And yes, we made sure that transition to the new suite is a breeze.</p>
            </div>
        </div>
    </div>
    <div class="footer">
        <div class="footer-content">
            <div class="copyright" runat="server" ID="Copyright">
                Copyright © <%# DateTime.Now.Year %> Developer Express Inc.<br />
                All trademarks or registered trademarks are property of their respective owners.
            </div>
            <a href="http://devexpress.com" target="_blank" class="logo"></a>
        </div>
    </div>
</body>
</html>
