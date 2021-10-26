using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AHakkimda : System.Web.UI.Page
    {
        CvDBEntities1 ent = new CvDBEntities1();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Repeater1.DataSource = ent.YETENEKLER.ToList();
                Repeater1.DataBind();
            }
        
        }
    }
}