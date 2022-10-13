using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class NoteData
    {
        public NoteData()
        {
            data = new DataAccess();
        }
        public DataAccess data;
        public List<Note> Listing()
        {
            List<Note> list = new List<Note>();
            try
            {
                data.Query("select Id, IdTheme, IdUser, Title, Description from Note");
                data.Read();
                while (data.readerProp.Read())
                {
                    Note aux = new Note();
                    aux.Id = (int)data.readerProp["Id"];
                    aux.IdTheme = (int)data.readerProp["IdTheme"];
                    aux.IdUser = (int)data.readerProp["IdUser"];
                    aux.Title = (string)data.readerProp["Title"];
                    aux.Description = (string)data.readerProp["Description"];
                    list.Add(aux);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close();}
        }
    
        public void Add(Note newnote)
        {
            try
            {
                data.Query("insert into Note (Title, Description, IdTheme, IdUser) values (@Title, @Description, @IdTheme, @IdUser)");
                data.Parameters("@Title", newnote.Title);
                data.Parameters("@Description", newnote.Description);
                data.Parameters("@IdTheme", newnote.IdTheme);
                data.Parameters("@IdUser", newnote.IdUser);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close();}
        }
        public void Delete(int Id)
        {
            try
            {
                data.Query("delete Note where Id = "+Id);
                
                
                data.Execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
        
        public void Modificate(Note note)
        {

            data.Query("update Note set Title = @Title, Description = @Description where Id = @Id");
            data.Parameters("@Title", note.Title);
            data.Parameters("@Description", note.Description);
            data.Parameters("@Id", note.Id);
            data.Execute();
            data.Close();
        }
    }
}
