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
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"]);
            int IdTheme = int.Parse(Request.QueryString["IdTheme"]);
            NoteData NoteData = new NoteData();
            notes = NoteData.Listing().FindAll(x => x.IdUser == Id && x.IdTheme == IdTheme);
            if (!IsPostBack)
            {
                GvNote.DataSource = notes;
                GvNote.DataBind();
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"]);
            Response.Redirect("FrmHome.aspx?Id=" + Id);
        }

        protected void BtnView_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"]);
            int IdTheme = int.Parse(Request.QueryString["IdTheme"]);
            Response.Redirect("FrmThemeView.aspx?IdUser=" + Id + "&&IdTheme=" + IdTheme);
        }
    }
}