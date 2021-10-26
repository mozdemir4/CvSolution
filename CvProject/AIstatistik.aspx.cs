using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AIstatistik : System.Web.UI.Page
    {
        CvDBEntities1 entities = new CvDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = entities.YETENEKLER.Count().ToString();
            Label2.Text = entities.ILETISIM.Count().ToString();
            Label3.Text = entities.YETENEKLER.Average(x => x.DERECE).ToString();
            Label4.Text = entities.YETENEKLER.Max(x => x.DERECE).ToString();

        }
    }
}