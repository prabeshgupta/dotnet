using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace User;

    class UserCrud2
    {
        MySqlConnection conn;
        MySqlCommand command;

        void CreateConnection()
        {
            string constr= "Server=localhost;Database=console;Uid=root;Pwd=root;";
            conn = new MySqlConnection(constr);
            conn.Open(); 
        }

        void InsertUpdateDelete(string sql)
        {
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Operation Successfully");
        }

        void SelectRecords(string sql)
        {
            command = new MySqlCommand(sql, conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    Console.WriteLine("Id\t User Name\t Full Name\t Address\t email");
                    while (reader.Read())
                    {
                        string sid = reader["id"].ToString();
                        string user_name = reader["user_name"].ToString();
                        string full_name = reader["full_name"].ToString();
                        string address = reader["address"].ToString();
                        string email = reader["email"].ToString();
                        Console.WriteLine($"{sid}\t {user_name}\t {full_name}\t {address}\t {email}");
                    }
                }
                else
                {
                    Console.WriteLine("No records found");
                }
            }

            //reader.Close();
        }

        void SelectRecordsWithLINQ()
        {
            var users = GetUsers();
            if (users.Any())
            {
                Console.WriteLine("Id\t User Name\t Full Name\t Address\t email");
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}\t {user.UserName}\t {user.FullName}\t {user.Address}\t {user.Email}");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }

        void SelectRecordsWithDataTable(string sql)
        {
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Console.WriteLine("Id\t User Name\t Full Name\t Address\t email  ");
                foreach (DataRow row in dt.Rows)
                {
                    string sid = row["id"].ToString();
                    string user_name = row["user_name"].ToString();
                    string full_name = row["full_name"].ToString();
                    string address = row["address"].ToString();
                    string email = row["email"].ToString();
                    Console.WriteLine($"{sid}\t {user_name}\t {full_name}\t {address}\t {email}  ");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }

        void SelectRecordsWithDataSet(string sql)
        {
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Users");
            DataTable dt = ds.Tables["Users"];
            if (dt.Rows.Count != 0)
            {
                Console.WriteLine("Id\t User Name\t Full Name\t Address\t email  ");
                foreach (DataRow row in dt.Rows)
                {
                    string sid = row["id"].ToString();
                    string user_name = row["user_name"].ToString();
                    string full_name = row["full_name"].ToString();
                    string address = row["address"].ToString();
                    string email = row["email"].ToString();
                    Console.WriteLine($"{sid}\t {user_name}\t {full_name}\t {address}\t {email}  ");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }

        IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM users";
            command = new MySqlCommand(sql, conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        UserName = reader["user_name"].ToString(),
                        FullName = reader["full_name"].ToString(),
                        Address = reader["address"].ToString(),
                        Email = reader["email"].ToString()
                    });
                }
            }
            return users;
        }

        static void Main(string[] args)
        {
            UserCrud2 crud = new UserCrud2();
            try
            {
                crud.CreateConnection();
                x: Console.WriteLine("1> Insert\t 2> Update\t 3> Delete\t 4> Select\t 5> Select with LINQ\t 6> Select with DataTable\t 7> Select with DataSet");
                Console.WriteLine("Enter your choice: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string sql = "", uname = "", fname = "", address = "", email="";
                int id = 0;
                switch(n)
                {
                    case 1: 
                        Console.WriteLine("Enter a user name: ");
                        uname = Console.ReadLine();
                        Console.WriteLine("Enter your full name: ");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter your address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter your email address: ");
                        email = Console.ReadLine();
                        sql = $"INSERT INTO users (user_name, full_name, address, email) VALUES ('{uname}', '{fname}', '{address}', '{email}')";
                        crud.InsertUpdateDelete(sql);
                        break;

                    case 2:
                        Console.WriteLine("Enter an Id to be updated");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a user name: ");
                        uname = Console.ReadLine();
                        Console.WriteLine("Enter your full name: ");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter your address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter your email address: ");
                        email = Console.ReadLine();
                        sql = $"UPDATE users SET user_name = '{uname}', full_name = '{fname}', address = '{address}', email = '{email}' WHERE id = {id}";
                        crud.InsertUpdateDelete(sql);
                        break;

                    case 3:
                        Console.WriteLine("Enter an id to delete: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        sql = $"DELETE FROM users WHERE id = {id}";
                        crud.InsertUpdateDelete(sql);
                        break;

                    case 4:
                        sql = "SELECT * FROM users";
                        crud.SelectRecords(sql);
                        break;

                    case 5:
                        crud.SelectRecordsWithLINQ();
                        break;

                    case 6:
                        sql = "SELECT * FROM users";
                        crud.SelectRecordsWithDataTable(sql);
                        break;

                    case 7:
                        sql = "SELECT * FROM users";
                        crud.SelectRecordsWithDataSet(sql);
                        break;

                    default: 
                        Console.WriteLine("Incorrect Choice");
                        break;

                }
                goto x; 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Operation Failed !");
            }
            Console.ReadKey();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
