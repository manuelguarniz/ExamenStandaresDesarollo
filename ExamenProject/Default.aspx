<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExamenProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script>

        $(function () {
            Fn_Init();
        });

        function Fn_Init() {
            Fn_ListAll();
        }


        function Fn_ListAll() {

            var sendData = {};
            
            var success = function (response) {

                try {
                    var obj = response.d;
                    var item = "";
                    if (response.d.length <= 0) {
                        fn_message("e", "An error occurred while loading");
                    } else {
                        var object = {};
                        object.request = obj;

                        item = Fn_LoadTemplates('datatable-order', object);


                        try { $("#tbOrder").dataTable().fnClearTable(); } catch (e) { }
                        try { $("#tbOrder").dataTable().fnDestroy(); } catch (e) { }

                        $("#tbOrder tbody").html(item);
                        $('#tbOrder').DataTable();
                    }
                } catch (e) {
                    fn_message("e", "An error occurred while loading");
                }
                $("#tbOrder").find(".loader_fb_16x16").remove();
            };

            var error = function (xhr, ajaxOptions, thrownError) {
                fn_message("e", "An error occurred while loading");
                $("#tbOrder").find(".loader_fb_16x16").remove();
            };

            var complete = function () {
                $("#tbOrder").find(".loader_fb_16x16").remove();
            };


            Fn_CallMethod("Default.aspx/OrderEntry_GetAll", JSON.stringify(sendData), success, error, complete);
        }
    </script>

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-12">
            <table id="tbOrder" class="table table-striped table-custom">
                <thead style="display:none;">
                    <tr>
                        <th>Id</th>
                        <th>LegacyNumber</th>
                        <th>DistributorId</th>
                        <th>OrderTotal</th>
                        <th>Status</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>

    <script type="text/x-handlebars-template" id="datatable-order">
        {{# each request}}
            <tr>
                <td>{{Id}}</td>
                <td>{{LegacyNumber}}</td>
                <td>{{DistributorId}}</td>
                <td>{{OrderTotal}}</td>
                <td>{{Status}}</td>
            </tr>
        {{/each}}
    </script>
</asp:Content>
