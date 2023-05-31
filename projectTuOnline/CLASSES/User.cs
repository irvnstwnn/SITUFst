using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTuOnline.CLASSES
{
    internal class User
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean addUser(string namaa, string nimm, string emaill, string password)
        {
            string query = "INSERT INTO `user`(`nama`, `nim`, `email`, `password`) VALUES (@namaa, @nimm, @emaill, @password)";
            MySqlParameter[] parameters = new MySqlParameter[4];
            parameters[0] = new MySqlParameter("@namaa", MySqlDbType.VarChar);
            parameters[0].Value = namaa;

            parameters[1] = new MySqlParameter("@nimm", MySqlDbType.VarChar);
            parameters[1].Value = nimm;

            parameters[2] = new MySqlParameter("@emaill", MySqlDbType.VarChar);
            parameters[2].Value = emaill;

            parameters[3] = new MySqlParameter("@password", MySqlDbType.VarChar);
            parameters[3].Value = password;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable checkLogin(string name, string pwd)
        {
            string query = "SELECT * FROM user WHERE `nim` = @name AND `password` = @pwd";
            MySqlParameter[] parameters = new MySqlParameter[2];

            parameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@pwd", MySqlDbType.VarChar);
            parameters[1].Value = pwd;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        public DataTable userList()
        {
            string query = "SELECT * FROM `user`";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
    }
}
