using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class DataBase
    {
        private SqlConnection connection;
        public DataBase()
        {
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GmailDB;Integrated Security=True");
        }
        public void Guardar(List<Email> emails)
        {
            try
            {
                using (connection)
                {
                    connection.Open();

                    foreach (Email email in emails)
                    {

                        if (email.New == 1)
                        {
                            string query = "Insert into dbo.Emails (Name,Email,Description) values " +
                                                           "('" + email.Nombre + "','" + email.DireccionEmail + "','" + email.Description + "')";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            email.New = 0;
                        }
                        else if (email.Modificated == 1)
                        {
                            string query = "update dbo.Emails set Name = '" + email.Nombre + "',Email ='" + email.DireccionEmail + "'" +
                                ",Description = '" + email.Description + "' where '" + email.DireccionEmail + "' = Email";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            email.Modificated = 0;
                        }else if (email.Avaible == 0)
                        {
                            string query = "delete from dbo.Emails where '"+email.DireccionEmail+"' = Email";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new MiException("Error al Guardar dbo", ex);
            }
        }
        public List<Email> Abrir()
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "select * from dbo.Emails";
                    List<Email> emails = new List<Email>();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        emails.Add(new Email(dataReader["Name"].ToString(), dataReader["Email"].ToString(),
                            dataReader["Description"].ToString(),1));
                    }
                    return emails;
                }
            }
            catch (Exception ex)
            {
                throw new MiException("Error al abrir dbo", ex);
            }
        }
    }
}
