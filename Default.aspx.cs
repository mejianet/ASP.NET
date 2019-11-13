using System;
using System.Web.UI;
using WebApplication1.ePx_ECM;
using DevExpress.Xpo;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if(!IsPostBack)
                {
                    carga_Init();
                }
            }
            catch
            {

            }
        }
        protected void carga_Init()
        {
            IDataLayer db_layer = XpoDefault.GetDataLayer(
            new SqlConnection(@"data source=bdmmejia.database.windows.net;user id=mmejia;password=ldmg3zhm*;initial catalog=ePx-ECM;Persist Security Info=true"),
            DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            Session session = new Session(db_layer);
            var inicio = session.Query<WFM_USER_SISTEMA>();
            //XpoDataSource1.DataBind();
            GridViewOne.DataSource = inicio;
            GridViewOne.DataBind();

        }
    }
}