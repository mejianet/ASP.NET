using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebApplication1.ePx_ECM;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //string conn = DevExpress.Xpo.DB.AccessConnectionProvider.GetConnectionString("ePx-ECM", "mmejia", "ldmg3zhm*");
            //DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            //// Initialize the XPO dictionary.
            //dict.GetDataStoreSchema(typeof(WFM_USER_SISTEMA).Assembly);
            //DevExpress.Xpo.XpoDefault.Session = null;
            //DevExpress.Xpo.DB.IDataStore store =
            //DevExpress.Xpo.XpoDefault.GetConnectionProvider(conn,
            //DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            //DevExpress.Xpo.XpoDefault.DataLayer = new DevExpress.Xpo.ThreadSafeDataLayer(dict, store);
        }
    }
}