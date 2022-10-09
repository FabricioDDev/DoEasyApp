using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace DoEasyWebProyect
{
    public partial class FrmThemeRegister : System.Web.UI.Page
    {
        private int IdUser;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            IdUser = int.Parse(Session["IdUser"].ToString());
            if(Request.QueryString["IdTheme"] != null && !IsPostBack)
            {
                ThemeData themeData = new ThemeData();
                Theme theme = themeData.Listing().Find(x => x.Id == int.Parse(Request.QueryString["IdTheme"]));
                TextBox1.Text = theme.Title;
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {

        }

        protected void BtnFinish_Click(object sender, EventArgs e)
        {
            
            ThemeData themeData = new ThemeData();
            Theme theme = new Theme();
            //falla txt
            theme.Title = TextBox1.Text;
            theme.Icon = new Icon();
            theme.Icon.Id = 1;
            
            //error con Id DEL TEMA(NO CONFUNDIR CON IDUSER).
            if (Request.QueryString["IdTheme"] != null)
            {
                theme.Id = int.Parse(Request.QueryString["IdTheme"]);
                themeData.ModificateTheme(theme);
            }
            else
            {
                theme.IdUser = int.Parse(Session["IdUser"].ToString());
                themeData.AddTheme(theme);
            }
            Response.Redirect("FrmHome.aspx");
        }

        
    }
}