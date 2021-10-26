using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AIletisimDetay : System.Web.UI.Page
    {
        CvDBEntities1 entities = new CvDBEntities1();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["ID"]);
            var deger = entities.ILETISIM.Find(id);
            TextBox1.Text = deger.MESAJ;
            
        }
    }
}