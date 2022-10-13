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
        public FrmThemeRegister()
        {
            iconList = new List<Icon>();
            
        }
        string IconSelected;
        private int IdUser;
        public List<Icon> iconList;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            IdUser = int.Parse(Session["IdUser"].ToString());
            if(Request.QueryString["IdTheme"] != null && !IsPostBack)
            {
                ThemeData themeData = new ThemeData();
                Theme theme = themeData.Listing().Find(x => x.Id == int.Parse(Request.QueryString["IdTheme"]));
                TextBox1.Text = theme.Title;
                LblIcon.CssClass = theme.Icon.Description;
            }
            IconData iconD = new IconData();
            iconList = iconD.Listing();
            RptIcon.DataSource = iconList;
            RptIcon.DataBind();
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmHome.aspx");
        }

        protected void BtnFinish_Click(object sender, EventArgs e)
        {
            
            ThemeData themeData = new ThemeData();
            Theme theme = new Theme();
            Icon icon = iconList.Find(x => x.Description == LblIcon.CssClass);
            
            theme.Title = TextBox1.Text;
            theme.Icon = new Icon();
            theme.Icon.Id = icon.Id;
            
            
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

        protected void LkbIcon_Click(object sender, EventArgs e)
        {
            IconSelected = ((LinkButton)sender).CommandArgument;
            LblIcon.CssClass = IconSelected;
        }
    }
}