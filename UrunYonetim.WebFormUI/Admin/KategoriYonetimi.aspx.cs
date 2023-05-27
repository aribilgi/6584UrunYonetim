using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.WebFormUI.Admin
{
    public partial class KategoriYonetimi : System.Web.UI.Page
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetCategories();
            dgvKategoriler.DataBind(); // web de bu metodu çağırmazsak ekrana veri yüklenmiyor!
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            var kategori = new Category()
            {
                CreateDate = DateTime.Now,
                Description = txtDescription.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text
            };
            manager.Add(kategori);
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                Response.Redirect("KategoriYonetimi.aspx");
            }
        }
    }
}