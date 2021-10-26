using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AIletisim : System.Web.UI.Page
    {
        CvDBEntities1 entities = new CvDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = entities.ILETISIM.ToList();
            Repeater1.DataBind();
        }
    }
}