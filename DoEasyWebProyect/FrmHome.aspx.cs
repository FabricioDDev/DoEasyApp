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
            ChargePage();
        }
        private void ChargePage()
        {
            IdUser = int.Parse(Session["IdUser"].ToString());
            //int Id = int.Parse(Request.QueryString["Id"]);
            List<Theme> CardList = new List<Theme>();
            ThemeData themeD = new ThemeData();
            CardList = themeD.Listing().FindAll(x => x.IdUser == IdUser);
            if (CardList.Count() < 1)
            {
                LblAlert.Text = "Todavia no has creado Tus Temas!";
            }    
                RptThemeCard.DataSource = CardList;
                RptThemeCard.DataBind();
            
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
            ChargePage();
        }

        protected void BtnDeleteTheme_Click(object sender, EventArgs e)
        {
            int IdTheme = int.Parse(((Button)sender).CommandArgument);
            ThemeData themeD = new ThemeData();
            themeD.Delete(IdTheme);
            NotesToDelete(IdTheme);
            ChargePage();
        }
        private void NotesToDelete(int IdTheme)
        {
            NoteData noteD = new NoteData();
            List<Note> notes = noteD.Listing().FindAll(x => x.IdTheme == IdTheme);
            foreach (Note note in notes)
            {
                noteD.Delete(note.Id);
            }
        }
    }
}