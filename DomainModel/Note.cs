using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Note
    {
        public int Id { get; set; }
        public int IdTheme { get; set; }
        public int IdUser { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
