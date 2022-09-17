using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class IconData
    {
        public IconData()
        {
            data = new DataAccess();
        }
        private DataAccess data;
        public List<Icon> Listing()
        {
            List<Icon> list = new List<Icon>();
            try
            {
                data.Query("select Id, Description from Icon");
                data.Read();
                while (data.readerProp.Read())
                {
                    Icon aux = new Icon();
                    aux.Id = (int)data.readerProp["Id"];
                    aux.Description = (string)data.readerProp["Description"];
                    list.Add(aux);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}

