<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
    <meta name="generator" content="Bootply" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="~/favglyphicon.ico" rel="shortcut glyphicon" type="image/x-glyphicon" />
    <meta name="viewport" content="width=device-width" />
    <!--[if lt IE 9]>
          <script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->
    <title>@ViewData("Title") - Online Contact Management</title>
  @*  @Styles.Render("~/Content/css")*@
   
    @Scripts.Render("~/bundles/jquery")
     @Scripts.Render("~/bundles/modernizr")

    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/bootstrap.min.css")" />
    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/bootstrap-responsive.min.css")" />

    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/custom-bootstrap-min.css")" />
    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/custom-bootstrap-responsive-min.css")" />
    <style>
        

    </style>
</head>
<body>
<div id="wrap">
    <div class="navbar navbar-fixed-top">
     <div class="navbar-inner">
        <div class="container">
           @* <header>*@
         <a data-target=".nav-collapse" data-toggle="collapse" class="btn btn-navbar">
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
       </a>
      @Html.ActionLink("Online Contact", "Index", "Home", DBNull.Value, New With {.class = "brand"})
                <div id="main-menu" class="nav-collapse collapse">
                    <ul id="main-menu-left" class="nav">
                        <li class="active">@Html.ActionLink("Home", "Index", "Home", DBNull.Value, DBNull.Value)</li>
                        <li>@Html.ActionLink("About", "About", "Home")</li>
                        <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                       <li>@Html.ActionLink("Add New Contact", "Index", "Home", DBNull.Value, DBNull.Value)</li>                      
                    </ul>

                     <ul id="main-menu-right" class="nav pull-right">
                         @Html.Partial("_LogOnPartial")
                     </ul>
                </div>
                <!--/.nav-collapse -->
            </header>
        </div>
        </div>
    </div>
    <div class="body container">
        <div class="body">
            @RenderSection("featured", required:=False)
            @RenderBody()
        </div>
    </div>
</div>
<div id="footer">
  <footer class=" footer container">
        <p class="pull-right">
            &copy; @DateTime.Now.Year -Alexandre meli contact application</p>
    </footer>
  </div>

     @Scripts.Render("~/bundles/bootstrapjquery")
    @RenderSection("Scripts", required:=False)

    <!-- JavaScript jQuery code from Bootply.com editor -->
    <script type='text/javascript'>

        $(document).ready(function () {

        });       
</script>
</body>
</html>
