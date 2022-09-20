using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class UserData
    {
        public UserData()
        {
            data = new DataAccess();
        }
        public DataAccess data;
        public List<User> Listing()
        {
            List<User> list = new List<User>();
            try
            {
                data.Query("select NroUser, UserName, UserMail, UserPass from UserTable");
                data.Read();
                while (data.readerProp.Read())
                {
                    User aux = new User();
                    aux.NroUser = (int)data.readerProp["NroUser"];
                    aux.Name = (string)data.readerProp["UserName"];
                    aux.Mail = (string)data.readerProp["UserMail"];
                    aux.Pass = (string)data.readerProp["UserPass"];
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
        
        public void Add(User newUser)
        {
            try
            {
                data.Query("insert into UserTable (UserName, UserMail, UserPass) values (@User, @Mail, @Pass)");
                data.Parameters("@User", newUser.Name);
                data.Parameters("@Mail", newUser.Mail);
                data.Parameters("@Pass", newUser.Pass);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
