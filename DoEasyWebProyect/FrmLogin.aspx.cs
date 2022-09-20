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
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LbSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmSignIn.aspx");
        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            User newUser = new User();
            try
            {
                newUser.Name = TxtUser.Text;
                newUser.Mail = TxtMail.Text;
                if (TxtPass.Text == TxtPass2.Text)
                {
                    newUser.Pass = TxtPass.Text;
                }
                   
                else
                {
                    TxtPass.Text = "No hay Coincidencias";
                    TxtPass2.Text = "";
                }
                userData.Add(newUser);
                Response.Redirect("FrmSignIn.aspx");
            }
            catch(Exception)
            {
                TxtUser.Text = "vuelva a intentarlo";
            }
        }
    }
}