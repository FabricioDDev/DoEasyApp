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
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdUser = int.Parse(Request.QueryString["IdUser"]);
            int IdTheme = int.Parse(Request.QueryString["IdTheme"]);
            NoteData NoteData = new NoteData();
            notes = NoteData.Listing().FindAll(x => x.IdUser == IdUser && x.IdTheme == IdTheme);
            if (!IsPostBack)
            {
                RptNote.DataSource = notes;
                RptNote.DataBind();
            }
        }
    }
}