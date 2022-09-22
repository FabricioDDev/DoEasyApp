using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Theme
    {
        public Theme()
        {
            Notes = new List<Note>();
            Note notePredeterminate = new Note();
            notePredeterminate.Title = "Default";
            notePredeterminate.Description = "Default";
            Notes.Add(notePredeterminate);
            
        }
        
        public int Id { get; set; }
        public string Title { get; set; }
        public Icon Icon { get; set; }
        public List<Note> Notes { get; set; }
        public int IdUser { get; set; }
    }
}
