using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;

namespace FinalProject.Database.Repository
{

    public class User : DatabaseConnection
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string usename, string password) { 
            Id = id;
            Username = usename; 
            Password = password;    
        }

        public static User GetUserFromUsernameAndPassword(string username, string password)
        {
            connection.Open();
            string query = $"select * from users where username='{username}' and password='{password}'";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            SQLiteDataReader userDataReader = command.ExecuteReader();

            List<User> users = new List<User>();

            while (userDataReader.Read())
            {
                User user = new User(
                    Int32.Parse(userDataReader["id"].ToString()),
                    userDataReader["username"].ToString(),
                    userDataReader["password"].ToString()
                );
                users.Add(user);

                Debug.WriteLine(user.Username, user.Password);
            }

            connection.Close();

            if(users.Count == 0)
            {
                return null;
            }

            return users[0];
        }
    }
}
