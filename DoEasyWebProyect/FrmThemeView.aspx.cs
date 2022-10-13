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
    public partial class FrmThemeView : System.Web.UI.Page
    {
        public FrmThemeView()
        {
            notes = new List<Note>();
        }
        private List<Note> notes;
        private int IdUser;
        private int IdTheme;
        protected void Page_Load(object sender, EventArgs e)
        {
            ChargePage();
        }

        private void ChargePage()
        {
            NoteData NoteData = new NoteData();

            IdUser = int.Parse(Session["IdUser"].ToString());
            IdTheme = int.Parse(Request.QueryString["IdTheme"]);

            notes = NoteData.Listing().FindAll(x => x.IdUser == IdUser && x.IdTheme == IdTheme);
            
                RptNote.DataSource = notes;
                RptNote.DataBind();
            
            ThemeData themeD = new ThemeData();
            Theme ThemeSelected = themeD.Listing().Find(x => x.Id == IdTheme);
            LblTitle.Text = ThemeSelected.Title;
            LblIcon.CssClass = ThemeSelected.Icon.Description;
        }
        protected void BtnBack_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("FrmHome.aspx");
        }

        protected void BtnView_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("FrmThemeViewV2.aspx?IdTheme=" + IdTheme);
        }

        protected void BtnConfig_Click(object sender, EventArgs e)
        {
            int View = 1;
            Response.Redirect("FrmThemeRegister.aspx?IdTheme=" + IdTheme + "&&View=" + View);
        }

        protected void BtnAddNote_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmNoteRegister.aspx?IdTheme=" + IdTheme);
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            //mandar Id DE LA NOTA.
            int IdNote = int.Parse(((Button)sender).CommandArgument);
            Response.Redirect("FrmNoteRegister.aspx?Id=" + IdNote + "&&IdTheme=" + IdTheme);
        }

        protected void BtnTrash_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(((Button)sender).CommandArgument);
            NoteData noteD = new NoteData();
            noteD.Delete(Id);
            ChargePage();
        }
    }
}