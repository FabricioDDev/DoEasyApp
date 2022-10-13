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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserData UD = new UserData();
           
            if (Session["IdUser"] != null)
            {
                int  IdUser = int.Parse(Session["IdUser"].ToString());
                User user = UD.Listing().Find(x => x.NroUser == IdUser);
                BtnUser.Text = user.Name;
            }
                
        }

        protected void BtnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmUserInfo.aspx");
        }

        protected void LkbOut_Click(object sender, EventArgs e)
        {
            Session.Remove("IdUser");
            Response.Redirect("FrmSignIn.aspx");
        }
    }
}