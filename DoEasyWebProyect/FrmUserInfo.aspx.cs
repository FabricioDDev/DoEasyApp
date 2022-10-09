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
    public partial class FrmUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmHome.aspx");
        }

        protected void BtnFinish_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            User user = new User();
            user.Name = TxtUserName.Text;
            user.Mail = "fabriciodamiandipaola@gmail.com";
            user.NroUser = int.Parse(Session["IdUser"].ToString());
            userData.Modificate(user);
            Response.Redirect("FrmHome.aspx");
        }
    }
}