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
    public partial class FrmNoteRegister : System.Web.UI.Page
    {
        private int IdUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            //tiene q recibir Id si es modificar
            //recibe IdTheme
            //recibe IdUser
            IdUser = int.Parse(Session["IdUser"].ToString());
            if (Request.QueryString["Id"] != null && !IsPostBack)
            {
                NoteData NoteD = new NoteData();
                Note note = NoteD.Listing().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
                TxtTitle.Text = note.Title;
                TxtNote.Text = note.Description;
            }
        }

        protected void BtnFinish_Click(object sender, EventArgs e)
        {
            NoteData noteD = new NoteData();
            Note note = new Note();
            note.Title = TxtTitle.Text;
            note.Description = TxtNote.Text;
            note.IdUser = IdUser;
            if (Request.QueryString["Id"] != null)
            {
                note.Id = int.Parse(Request.QueryString["Id"]);
                noteD.Modificate(note);
            }
            else
            {
                note.IdTheme = int.Parse(Request.QueryString["IdTheme"]);
                
                noteD.Add(note);
            }
            Response.Redirect("FrmThemeView.aspx?IdTheme=" + Request.QueryString["IdTheme"]);
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmThemeView.aspx?IdTheme=" + Request.QueryString["IdTheme"]);
        }
    }
}