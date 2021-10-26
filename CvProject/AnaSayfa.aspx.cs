using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        CvDBEntities1 cvDB = new CvDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            // ad soyad - responsive
            Repeater1.DataSource = cvDB.HAKKIMDA.ToList();
            Repeater1.DataBind();

           
            // ad ve soyad
            AdRepeat.DataSource = cvDB.HAKKIMDA.ToList();
            AdRepeat.DataBind();

            EgıtımRepeat.DataSource = cvDB.HAKKIMDA.ToList();
            EgıtımRepeat.DataBind();

            // iş deneyimleri
            DeneyımRepeat.DataSource = cvDB.HAKKIMDA.ToList();
            DeneyımRepeat.DataBind();

            // yetenekler

            Repeater2.DataSource = cvDB.YETENEKLER.ToList();
            Repeater2.DataBind();

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ILETISIM t = new ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            cvDB.ILETISIM.Add(t);
            cvDB.SaveChanges();
        }
    }
}