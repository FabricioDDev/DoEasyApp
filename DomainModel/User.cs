using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class User
    {
        public User()
        {
            Theme = new List<Theme>();
            Theme theme = new Theme();
            theme.Title = "Default";
            theme.Icon = "fas fa-sticky - note";
            Theme.Add(theme);
        }
        public int NroUser { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public List<Theme> Theme { get; set; }
    }
}
