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
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")

    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/bootstrap.min.css")" />
    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/bootstrap-responsive.min.css")" />

    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/custom-bootstrap-min.css")" />
    <link type="text/css" rel="Stylesheet" href="@Url.Content("~/Content/css/custom-bootstrap-responsive-min.css")" />
    <style>
        body
        {
            padding-top: 50px;
        }
        
        .table-vcenter td
        {
            vertical-align: middle !important;
        }
        .table-vcenter td .btn, .table-vcenter td div .btn
        {
            margin-top: 0px !important;
        }
        
        .table-vcenter td input, .table-vcenter td select
        {
            margin-bottom: 0px !important;
        }
        
        div.row-fluid.address div.span4
        {
            position: relative;
        }
        
        div.row-fluid.address div.span4 input, table.phone-number input
        {
            background-color: #FFF;
            border: 1px solid #CCC;
            box-shadow: 0px 1px 1px rgba(0, 0, 0, 0.075) inset;
            transition: border 0.2s linear 0s, box-shadow 0.2s linear 0s;
            display: inline-block;
            height: 20px;
            padding: 4px 6px;
            margin-bottom: 10px;
            font-size: 14px;
            line-height: 20px;
            color: #555;
            vertical-align: middle;
            border-radius: 4px;
        }
        
        div.row-fluid.address div.span4 div.m-button
        {
            position: absolute;
            top: 0px;
            margin-top: 0px;
            margin-left: 5px;
            width: auto !important;
        }
        
        div.row-fluid.address div.span4 div.m-button .btn
        {
            margin-top: 0px !important;
        }
        
        table.phone-number div.pull-right form
        {
            margin: 0px 0px 0px 5px;
            float: right;
        }
        
        table.table-bordered.table-vcenter thead:first-child tr:first-child > th:last-child
        {
            width: 175px;
        }
        
        h3.warning()
        {
            color: #DA4F49;
        }
        h4.info()
        {
            color: #DA4F49;
            background-color: #49AFCD;
            padding: 0.75em;
            box-sizing: border-box;
            -moz-box-sizing: border-box; /* Firefox */
            -web-box-sizing: border-box; /* Firefox */
            border: 1px solid orange;
            color: #fff;
            border-radius: 4px;
        }
        
        h4.error()
        {
            color: #DA4F49;
            background-color: #FAA732;
            padding: 0.75em;
            box-sizing: border-box;
            -moz-box-sizing: border-box; /* Firefox */
            -web-box-sizing: border-box; /* Firefox */
            border: 1px solid #DA4F49;
            color: #fff;
            border-radius: 4px;
        }
        
        h4.success()
        {
            background-color: #5BB75B;
            padding: 0.75em;
            box-sizing: border-box;
            -moz-box-sizing: border-box; /* Firefox */
            -web-box-sizing: border-box; /* Firefox */
            border: 1px solid #49AFCD;
            color: #fff;
            border-radius: 4px;
        }
        
        hr[class^="span"]
        {
            margin-top: 0px;
            margin-bottom: 0px;
        }
        
        
        
        
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
        <div class="body text-center">
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

    @Scripts.Render("~/bundles/jquery")
    <!-- JavaScript jQuery code from Bootply.com editor -->
    <script type='text/javascript'>

        $(document).ready(function () {

        });       
</script>
</body>
</html>
