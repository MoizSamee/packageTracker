#pragma checksum "C:\Users\Moiz\OneDrive\Documents\GitHub\packageTracker\PackageTracker\PackageTracker\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cc54a37c259a8e928901406045d8de65e06dd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PackageTracker.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PackageTracker.Pages
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
#line 1 "C:\Users\Moiz\OneDrive\Documents\GitHub\packageTracker\PackageTracker\PackageTracker\Pages\_ViewImports.cshtml"
using PackageTracker;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cc54a37c259a8e928901406045d8de65e06dd1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5aa4b7cc440c45446b26a1a8200da809d80bba6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Moiz\OneDrive\Documents\GitHub\packageTracker\PackageTracker\PackageTracker\Pages\Index.cshtml"
  
    ViewData["Title"] = "Package Tracker";
    


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cc54a37c259a8e928901406045d8de65e06dd14619", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40cc54a37c259a8e928901406045d8de65e06dd14881", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"" style=""padding-bottom:30px;"">Welcome to Project tracker</h1>

</div>

<div id=""container"">

    <button type=""button"" class=""btn btn-primary btn-lg"" id=""createorder-btn"">Create New Order</button>

    <button type=""button"" class=""btn btn-primary btn-lg"" id=""createcustomer-btn"">Create New Customer</button>

    <button type=""button"" class=""btn btn-primary btn-lg"" id=""orders-btn"">Orders</button>

    <button type=""button"" class=""btn btn-primary btn-lg"" id=""customerinfo-btn"">Customer Info</button>

    <div id=""orders"" style=""display:none"">

        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Customer ID
                    </th>
                    <th>
                        Shipping ID
                    </th>
                    <th>
                        Package Status
                    </th>
                    <th>
                        Price
    ");
            WriteLiteral(@"                </th>
                    <th>
                        Source
                    </th>
                    <th>
                        Destination
                    </th>
                    <th>
                        Last Update
                    </th>
                    <th>
                        Weight
                    </th>

                </tr>
            </thead>

            <tbody id=""shippinglistbody"">
            </tbody>
        </table>
        <button type=""button"" class=""btn btn-outline-secondary"" id=""backindexorder"" onclick=""window.location='/';"">Go Back</button>
    </div>

    <div id=""customerinfo"" style=""display:none"">
");
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Customer ID
                    </th>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                    <th>
                        Date of Birth
                    </th>
                    <th>
                        Customer Address
                    </th>
                    <th>
                        Phone No
                    </th>
                    <th>
                        Prime Member
                    </th>

                </tr>
            </thead>

            <tbody id=""custlistbody"">
            </tbody>
        </table>
        <button type=""button"" class=""btn btn-outline-secondary"" id=""backindexcust"" onclick=""window.location='/';"">Go Back</button>
    </div>

    <div id=""neworder"" style=""display:none"">");
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cc54a37c259a8e928901406045d8de65e06dd19690", async() => {
                WriteLiteral(@"

            <div class=""form-group"">
                <label class=""control-label"">Customer ID</label>
                <input class=""form-control"" id=""customerid"" type=""number"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Package Status</label>
                <input class=""form-control"" id=""packagestatus"" />

            </div>
            
            <div class=""form-group"">
                <label class=""control-label"">weight</label>
                <input class=""form-control"" id=""weight"" type=""number"">

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Source Address</label>
                <input class=""form-control"" id=""sourceaddress"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Destination Address</label>
                <input class=""form-control"" id=""destinationaddress"" />

            </div>
           ");
                WriteLiteral(@" <div class=""form-group"">
                <label class=""control-label"">price</label>
                <input class=""form-control"" id=""price"" type=""number""/>

            </div>
            
            <div class=""form-group"">
                <input type=""submit"" id=""submitcreateorder"" value=""Create"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <button type=\"button\" class=\"btn btn-outline-secondary\" id=\"backindexorder\" onclick=\"window.location=\'/\';\">Go Back</button>\r\n    </div>\r\n\r\n\r\n    <div id=\"newcustomer\" style=\"display:none\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cc54a37c259a8e928901406045d8de65e06dd112844", async() => {
                WriteLiteral(@"
            
            <div class=""form-group"">
                <label class=""control-label"">First Name</label>
                <input class=""form-control"" id=""firstname"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Last Name</label>
                <input class=""form-control"" id=""lastname"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Date Of Birth</label>
                <input class=""form-control"" type=""date"" id=""dob"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Address</label>
                <textarea class=""form-control"" id=""address"" rows=""4""></textarea>

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Phone No</label>
                <input type=""number"" class=""form-control"" id=""phoneno"" type=""number"" minlength=""9"" maxlength=""11"" />

            ");
                WriteLiteral(@"</div>
            <div class=""form-group"">
                <label class=""control-label"">Prime Customer</label>
                <input class=""form-control"" id=""primecustomer"" type=""checkbox"" />

            </div>
            <div class=""form-group"">
                <input type=""submit"" id=""submitcreateuser"" value=""Create"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <button type=""button"" class=""btn btn-outline-secondary"" id=""backindexorder"" onclick=""window.location='/';"">Go Back</button>

    </div>

</div>


<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"" style=""padding-top: 30px;"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        
        <div class=""carousel-item active"">
            <img class=""d-block w-100"" src=""https://ichef.bbci.co.uk/news/976/cpsprodpb/136D0/production/_106186597_medium.jpg"" alt=""First slide"" width=""800"" height=""600"">
            <div class=""carousel-caption d-none d-md-block"">
                <h1 style=""color:black"">Best in class service</h1>
                
            </div>
           
        </");
            WriteLiteral(@"div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""https://cdn.motor1.com/images/mgl/91k8p/s1/rivian-amazon-electric-delivery-truck-on-road.jpg"" alt=""Second slide"" width=""800"" height=""600"">
            
            <div class=""carousel-caption text-"">
                <h1 style=""color:white"">Choose us for the fastet delivery service in the country</h1>

            </div>

        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""https://www.groovypost.com/wp-content/uploads/2019/05/package-delivery-tracking-featured.jpg"" alt=""Third slide"" width=""800"" height=""600"">
            
            <div class=""carousel-caption d-none d-md-block"">
                <h2>Special benefits for Prime members</h2>
                <button class=""btn btn-outline-primary"" onclick=""window.location='/shipinfo';"">Track Package</button>

            </div>
            
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carous");
            WriteLiteral(@"elExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>


        $(function () {


        });

            $(""#orders-btn"").click(function () {
                console.log('orders button clicked')
                $(""#orders"").toggle();
                $(""#customerinfo-btn"").toggle();
                $(""#orders-btn"").toggle();
                $(""#createorder-btn"").toggle();
                $(""#createcustomer-btn"").toggle();
                $(""#carouselExampleIndicators"").toggle();
");
                WriteLiteral(@"                loadShippingData();

            });


            $(""#createorder-btn"").click(function () {
                $(""#neworder"").toggle();

                $(""#customerinfo-btn"").toggle();
                $(""#orders-btn"").toggle();
                $(""#createorder-btn"").toggle();
                $(""#createcustomer-btn"").toggle();
                $(""#carouselExampleIndicators"").toggle();

            });


            $(""#createcustomer-btn"").click(function () {

                $(""#newcustomer"").toggle();
                $(""#customerinfo-btn"").toggle();
                $(""#orders-btn"").toggle();
                $(""#createorder-btn"").toggle();
                $(""#createcustomer-btn"").toggle();
                $(""#carouselExampleIndicators"").toggle();

            });

            $(""#customerinfo-btn"").click(function () {
                console.log('cust info button clicked')
                $(""#customerinfo"").toggle();
                $(""#orders-btn"").toggle();
     ");
                WriteLiteral(@"           $(""#customerinfo-btn"").toggle();
                $(""#createorder-btn"").toggle();
                $(""#createcustomer-btn"").toggle();
                $(""#carouselExampleIndicators"").toggle();
                loadCustData();

            });


            var locationLongitude = null;
            var locationLatitude = null;

            if (navigator.geolocation != null) { // CHECK IF location IS AVAILABLE
                console.log(""has location access"");
                navigator.geolocation.getCurrentPosition(function (locationInfo) {
                    console.log(""location"", locationInfo);
                    locationLatitude = locationInfo.coords.latitude;
                    locationLongitude = locationInfo.coords.longitude;
                    console.log('Latitide: ' + locationLatitude);
                    console.log('Longitude: ' + locationLongitude);
                });
            }

            $(""#submitcreateorder"").click(function (e) {
                e.pre");
                WriteLiteral(@"ventDefault();
                console.log('in the submit button fn')
                var customerId = parseInt($(""#customerid"").val()) // TODO: GET DATA FROM INPUT
                var packageStatus = $(""#packagestatus"").val()
                var weight = parseInt($(""#weight"").val())
                var sourceAddress = $(""#sourceaddress"").val()
                var destinationAddress = $(""#destinationaddress"").val()
                var price = parseInt($('#price').val())
                var currentTime = new Date();
                console.log('making the ajax call for creating order')
                var request = JSON.stringify({
                    customerId: customerId,
                    packageStatus: packageStatus,
                    weight: weight,
                    sourceAddress: sourceAddress,
                    destinationAddress: destinationAddress,
                    price: price,
                    latitude: locationLatitude,
                    longitude: locationLongit");
                WriteLiteral(@"ude,
                    updatedTimestamp: currentTime

                })
                console.log(request)

                $.ajax({

                    url: ""/api/ShippingInfoes"",
                    dataType: ""json"",
                    contentType: ""application/json"",
                    data: request,
                    method: ""POST""

                }).done(function () {
                    console.log(""activity logged""); //TODO: HANDLE THE SUCCESS STATE

                    alert(""Order Succsessfully created"")
                }).fail(function () {
                    alert(""something went bad"")
                    console.log(""there was an error creating order""); //TODO: HANDLE THE FAILURE STATE
                })
                return false;

            });



            $(""#submitcreateuser"").click(function () {
                console.log('in the submit button fn')
                var firstName = $(""#firstname"").val(); // TODO: GET DATA FROM INPUT
           ");
                WriteLiteral(@"     var lastName = $(""#lastname"").val();
                var address = $(""#address"").val();
                var dateOfBirth = $(""#dob"").val();
                console.log(dateOfBirth)
                var phoneNo = parseInt($(""#phoneno"").val());
                var primeCustomer = $('#primecustomer').prop('checked')
                console.log('making the ajax call')
                var request = JSON.stringify({
                    firstName: firstName,
                    lastName: lastName,
                    dateOfBirth: dateOfBirth,
                    custAddress: address,
                    phoneNumber: parsenInt(phoneNo),
                    primeCustomer: primeCustomer

                })
                console.log(request)

                $.ajax({

                    url: ""/api/CustomerInfoes"",
                    dataType: ""json"",
                    contentType: ""application/json"",
                    data: request,
                    method: ""POST""

               ");
                WriteLiteral(@" }).done(function () {
                    console.log(""activity logged""); //TODO: HANDLE THE SUCCESS STATE

                    alert(""New custmoer created succdssfully!"")
                }).fail(function () {
                    alert(""something went bad"")
                    console.log(""there was an error creating user""); //TODO: HANDLE THE FAILURE STATE
                })
                return false;

            });



            function loadShippingData() {
                console.log('making the API call')
            $.ajax({
                url: ""api/ShippingInfoes"",
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function (responseJSON, status, xhr) {
                // process the response when status code is 200-299
                builShippingList(responseJSON);

                console.log(responseJSON);
            }).fail(function (xhr, status, error) {
                // deal wi");
                WriteLiteral(@"th error from server (status code 400-599)
                alert(""There was an error retrieving the data"");
            });

        }

        function builShippingList(shippingitem) {
            $(""#shippinglistbody"").empty();
            $.each(shippingitem, function (index, item) {

");
                WriteLiteral(@"                var td = $('<tr><td id=""ID"" item-id=' + item.customerId + '>' + item.customerId + '</td>' +
                    '<td id=' + item.id + '"">' + item.id + '</td>' +
                    '<td id=' + item.packageStatus + '"">' + item.packageStatus + '</td>' +
                    '<td id=' + item.price + '"">' + item.price + '</td>' +
                    '<td id=' + item.sourceAddress + '"">' + item.sourceAddress + '</td>' +
                    '<td id=' + item.destinationAddress + '"">' + item.destinationAddress + '</td>' +
                    '<td id=' + item.updatedTimestamp + '"">' + item.updatedTimestamp + '</td>' +
                    '<td id=' + item.weight + '"">' + item.weight + '</td>' +
                    '</tr>')

                $(td).append('<a href=""Shipinfo/Edit?id=' + item.id+'"">Edit</a>')
                console.log(td)
                $(""#shippinglistbody"").append(td)

            });
        }


        function loadCustData() {
            console.log('making the API");
                WriteLiteral(@" call')
            $.ajax({
                url: ""api/CustomerInfoes"",
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function (responseJSON, status, xhr) {
                // process the response when status code is 200-299
                builCustList(responseJSON);
                console.log('built cust list')
                console.log(responseJSON);
            }).fail(function (xhr, status, error) {
                // deal with error from server (status code 400-599)
                alert(""There was an error retrieving the data"");
            });

        }

        function builCustList(custitem) {
            $(""#custlistbody"").empty();
            $.each(custitem, function (index, item) {

");
                WriteLiteral(@"                var td = $('<tr><td id=""ID"" item-id=' + item.custId + '>' + item.custId + '</td>' +
                    '<td id=' + item.firstName + '"">' + item.firstName + '</td>' +
                    '<td id=' + item.lastName + '"">' + item.lastName + '</td>' +
                    '<td id=' + item.dateOfBirth + '"">' + item.dateOfBirth + '</td>' +
                    '<td id=' + item.custAddress + '"">' + item.custAddress + '</td>' +
                    '<td id=' + item.phoneNumber + '"">' + item.phoneNumber + '</td>' +
                    '<td id=' + item.primeCustomer + '"">' + item.primeCustomer + '</td>' +
                    '</tr>')
                $(td).append('<a href=""Custinfo/Edit?id=' + item.custId + '"">Edit</a>')
                console.log(td)
                $(""#custlistbody"").append(td)


            });
        }


        </script>
    ");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
