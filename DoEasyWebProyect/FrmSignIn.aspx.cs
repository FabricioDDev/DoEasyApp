using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;
using DB;

namespace DoEasyWebProyect
{
    public partial class FrmSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LbLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmLogin.aspx");
        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            UserData UserData = new UserData();
            User user = UserData.Listing().Find(x => x.Name == TxtUser.Text || x.Mail == TxtUser.Text && x.Pass == TxtPass.Text);
            if(user != null)
            {
                Response.Redirect("FrmHome.aspx?Id=" + user.NroUser);
            }
            else
            {
                TxtUser.Text = "usuario incorrecto";
            }
        }
    }
}