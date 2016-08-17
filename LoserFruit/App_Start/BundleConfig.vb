Imports System.Web
Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery-{version}.js"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/twitch").Include(
                    "~/Scripts/twitch-player-v1.js"))

        bundles.Add(New ScriptBundle("~/bundles/fullmotion").Include(
                    "~/Scripts/fullmotion/jquery.poptrox.min.js",
                    "~/Scripts/fullmotion/jquery.scrolly.min.js",
                    "~/Scripts/fullmotion/main.js",
                    "~/Scripts/fullmotion/skel.min.js",
                    "~/Scripts/fullmotion/util.js"))


        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css"))
        bundles.Add(New StyleBundle("~/Content/fullmotion").Include(
                   "~/Content/fullmotion/font-awesome.min.css",
                    "~/Content/fullmotion/main.css"))
    End Sub
End Module