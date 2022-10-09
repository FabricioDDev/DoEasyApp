using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;


namespace DoEasyWebProyect.ClientForms
{
    public partial class FrmHome : System.Web.UI.Page
    {
        
        private int IdUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            IdUser = int.Parse(Session["IdUser"].ToString());
            //int Id = int.Parse(Request.QueryString["Id"]);
            List<Theme> CardList = new List<Theme>();
            ThemeData themeD = new ThemeData();
            CardList = themeD.Listing().FindAll(x => x.IdUser == IdUser);
            if (CardList.Count() > 0)
            {
                RptThemeCard.DataSource = CardList;
                RptThemeCard.DataBind();
            }
        }

        protected void BtnThemeView_Click(object sender, EventArgs e)
        {
            int IdTheme = int.Parse(((Button)sender).CommandArgument);
            //int Id = int.Parse(Request.QueryString["Id"]);
            Response.Redirect("FrmThemeView.aspx?IdTheme=" + IdTheme);
        }

        protected void BtnAddTheme_Click(object sender, EventArgs e)
        {
            //int Id = int.Parse(Request.QueryString["Id"]);
            Response.Redirect("FrmThemeRegister.aspx");
        }
    }
}