using System;
using UrunYonetim6584.BL;

namespace UrunYonetim.WebFormUI
{
    public partial class Default : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptUrunler.DataSource = manager.GetAll();
            rptUrunler.DataBind();
        }
    }
}