﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class Class1
    {
        MySqlConnection conn;

        public Class1()
        {
            string con_str = "SERVER=localhost;DATABASE=glbank;UID=root;PASSWORD=1234;";
            conn = new MySqlConnection(con_str);
        }

        private bool openConn()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }
        private bool closeConn()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }
        /*******************************************************************/

        public string getAccountId(long card_number)
        {
            string result = "";
            string query = "select * from cards where cardnumber = '" + card_number + "';";
            if (openConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader["idacc"].ToString();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                closeConn();
            }
            return result;
        }
        /**************************************************************************/
        public bool isCardBlocked(string card_number)
        {
            bool answer = true;
            string query = "select blocked from cards where cardnumber=" + card_number + ";";
            if (openConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        answer = reader["blocked"].ToString().Equals("T");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                closeConn();
            }

            return answer;
        }
    }
}
