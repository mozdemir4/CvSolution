using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class Login : System.Web.UI.Page
    {
        CvDBEntities1 ent = new CvDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from deger in ent.ADMIN where deger.KULLANICIADI == TextBox1.Text && deger.SIFRE == TextBox2.Text select deger;

            if (sorgu.Any())
            {
                Response.Redirect("AIstatistik.aspx");
            }
            else
            {
                Label1.Text = "Kullanıcı Adı veya Şifreniz Hatalı!!";
            }
        }
    }
}