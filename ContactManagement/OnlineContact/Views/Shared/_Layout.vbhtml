<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - My ASP.NET MVC Application</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />

    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr") 
    @Scripts.Render("~/bundles/jquery")

    
<style>
.table-vcenter td {
   vertical-align: middle!important;
}
.table-vcenter td .btn, .table-vcenter td div .btn {
   margin-top: 0px !important;
}

.table-vcenter td input, .table-vcenter td select  {
   margin-bottom: 0px !important;
}



div.row-fluid.address div.span4 
{
    position: relative
} 

div.row-fluid.address div.span4 input ,table.phone-number input 
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
    top:0px; 
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



table.table-bordered.table-vcenter thead:first-child tr:first-child > th:last-child{
    width: 175px;
}

h3.warning { color: #DA4F49; }
h4.info  
{
    color: #DA4F49; 
    background-color:#49AFCD;
     padding: 0.75em; 
     box-sizing:border-box;
    -moz-box-sizing:border-box; /* Firefox */
    -web-box-sizing:border-box; /* Firefox */
      border: 1px solid orange; 
      color: #fff;
      border-radius: 4px;}
      
 h4.error  
{
    color: #DA4F49; 
    background-color:#FAA732;
     padding: 0.75em; 
     box-sizing:border-box;
    -moz-box-sizing:border-box; /* Firefox */
    -web-box-sizing:border-box; /* Firefox */
      border: 1px solid #DA4F49; 
      color: #fff;
      border-radius: 4px;
      }
      
h4.success  
{
    background-color:#5BB75B;
     padding: 0.75em; 
     box-sizing:border-box;
    -moz-box-sizing:border-box; /* Firefox */
    -web-box-sizing:border-box; /* Firefox */
      border: 1px solid #49AFCD; 
      color: #fff;
      border-radius: 4px;
 }
      
hr[class^="span"] { margin-top: 0px; margin-bottom: 0px; }

</style>


    </head>
    <body>
@*        <header>
            <div class="content-wrapper">
                <div class="float-left">
                    <p class="site-title">@Html.ActionLink("your logo here", "Index", "Home")</p>
                </div>
                <div class="float-right">
                    <section id="login">
                        @Html.Partial("_LogOnPartial")
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Home", "Index", "Home")</li>
                            <li>@Html.ActionLink("About", "About", "Home")</li>
                            <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                @RenderBody()
            </section>
        </div>
        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - My ASP.NET MVC Application</p>
                </div>
            </div>
        </footer>*@
    <div class="container" style="font-family: Arial">
    <header>
          <div class="nav navbar">
            <ul class="nav navbar nav-tabs">
                <li class="active">@Html.ActionLink("Home", "Index", "Home", DBNull.Value, DBNull.Value)</li>
                <li>@Html.ActionLink("About", "About", "Home")</li>
                <li>@Html.ActionLink("Contact", "Contact", "Home")</li>   
                <li> @Html.ActionLink("Add New Contact", "Index", "Home", DBNull.Value, DBNull.Value)</li>                   
            </ul>

             <section id="login">
                        @Html.Partial("_LogOnPartial")
              </section>
        </div>
    </header>
      
    <div class="row-fluid">
        <div class="body span12" >

                 @RenderSection("featured", required:=false)

                @RenderBody()
        </div>      
    </div>

    <div class="row-fluid">
        <footer class="footer span12" >
               <p class="pull-right">&copy; @DateTime.Now.Year -Alexandre meli contact application</p>
        </footer>      
    </div>
      </div>  
   

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)
    </body>
</html>
