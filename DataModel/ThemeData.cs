using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class ThemeData
    {
        public ThemeData()
        {
            data = new DataAccess();
        }
        private DataAccess data;
        public List<Theme> Listing()
        {
            List<Theme> list = new List<Theme>();
            try
            {
                data.Query("select T.Id as Id, T.Title as Title, I.Id as IdIcon, I.Description as DescIcon, T.IdUser from Theme T, Icon I WHERE T.IdIcon = I.Id");
                data.Read();
                while (data.readerProp.Read())
                {
                    Theme aux = new Theme();
                    aux.Id = (int)data.readerProp["Id"];
                    aux.Title = (string)data.readerProp["Title"];
                    aux.Icon = new Icon();
                    aux.Icon.Id = (int)data.readerProp["IdIcon"];
                    aux.Icon.Description = (string)data.readerProp["DescIcon"];
                    aux.IdUser = (int)data.readerProp["IdUser"];
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

        public void AddTheme(Theme NewTheme)
        {
            try
            {
                data.Query("insert into Theme ( Title, IdIcon, IdUser) values (@Id, @Title, @Icon, @IdUser)");
                data.Parameters("@Title", NewTheme.Title);
                data.Parameters("@Icon", NewTheme.Icon.Description);
                data.Parameters("@IdUser", NewTheme.IdUser);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
        public void ModificateThem(Theme theme)
        {
            try{
                data.Query("update Theme set Title = @Title, IdIcon = @IdIcon");
                data.Parameters("@Title", theme.Title);
                data.Parameters("@IdIcon", theme.Icon.Id);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }

        }

        public void Delete(int Id)
        {
            try
            {
                data.Query("delete Theme where Id = @Id");
                data.Parameters("Id", Id);
                data.Execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
