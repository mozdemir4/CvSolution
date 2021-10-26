using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AYetenekGuncelle : System.Web.UI.Page
    {
        CvDBEntities1 entities = new CvDBEntities1();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                id = int.Parse(Request.QueryString["ID"]);
                var deger = entities.YETENEKLER.Find(id);
                TextBox1.Text = deger.YETENEK;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(Request.QueryString["ID"]);
            var deger = entities.YETENEKLER.Find(id);
            deger.YETENEK = TextBox1.Text;
            entities.SaveChanges();
            Response.Redirect("AYetenekler.aspx");
        }
    }
}