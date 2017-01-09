using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Asset_Management_System
{
    public class User
    {
        public string AuthenticateUser(string username, string password)
        {
            string myConnection = ConfigurationManager.ConnectionStrings["AMSDatabase"].ConnectionString;
            string Query = "select * from assetmanagement.users where username='" + username + "' and pass='" + password + "' ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            string userLevel = string.Empty;
            while (myReader.Read())
            {
                count = count + 1;
                userLevel = myReader["userLevel"].ToString();
            }
            myConn.Close();
            return userLevel;
        } 
    
    }
}
