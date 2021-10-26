using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AYeniyetenek : System.Web.UI.Page
    {
        CvDBEntities1 entities = new CvDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        { 

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            YETENEKLER y = new YETENEKLER();
            y.YETENEK = TextBox1.Text;
            entities.YETENEKLER.Add(y);
            entities.SaveChanges();
            Response.Redirect("AYetenekler.aspx");
        }
    }
}