using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AYetenekSil : System.Web.UI.Page
    {
        CvDBEntities1 ent = new CvDBEntities1();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            // silme işlemi

            id = Int16.Parse(Request.QueryString["ID"]);
            var sorgu = ent.YETENEKLER.Find(id);
            ent.YETENEKLER.Remove(sorgu);
            ent.SaveChanges();
            Response.Redirect("AYetenekler.aspx");
        }
    }
}