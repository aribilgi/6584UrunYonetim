﻿using System;
using UrunYonetim6584.BL;

namespace UrunYonetim.WebFormUI
{
    public partial class Onyuz : System.Web.UI.MasterPage
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptKategoriler.DataSource = manager.GetCategories();
            rptKategoriler.DataBind();
        }
    }
}