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
    public partial class FrmThemeViewV2 : System.Web.UI.Page
    {
        public FrmThemeViewV2()
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
            
                GvNote.DataSource = notes;
                GvNote.DataBind();

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
          
            Response.Redirect("FrmThemeView.aspx?IdTheme=" + IdTheme);
        }

        protected void BtnConfig_Click(object sender, EventArgs e)
        {
          
            int View = 2;
            Response.Redirect("FrmThemeRegister.aspx?IdTheme=" + IdTheme + "&&View=" + View);
        }

        protected void GvNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = GvNote.SelectedDataKey.Value.ToString();
            Response.Redirect("FrmNoteRegister.aspx?Id=" + Id + "&&IdTheme=" + Request.QueryString["IdTheme"]);
        }

        protected void GvNote_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = int.Parse(GvNote.DataKeys[e.RowIndex].Value.ToString());
            NoteData noteD = new NoteData();
            noteD.Delete(Id);
            ChargePage();
        }

        protected void BtnAddNote_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmNoteRegister.aspx?IdTheme=" + IdTheme);
        }
    }
}