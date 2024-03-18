using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace User;

class UserCrud1
{
    MySqlConnection conn;
    MySqlCommand command;

    void CreateConnection()
    {
        string constr = "Server=localhost;Database=crudapp;Uid=root;Pwd=root;";
        conn = new MySqlConnection(constr);
        conn.Open();
    }

    void InsertUpdateDelete(string sql)
    {
        command = new MySqlCommand(sql, conn);
        command.ExecuteNonQuery();
        Console.WriteLine("User Created Successfully");
    }

    void DisplayCount(string sql)
    {
        command = new MySqlCommand(sql, conn);
        string data = Convert.ToString(command.ExecuteScalar());
        Console.WriteLine($"THe total count is {data}");

    }

    void SelectRecords(string sql)
    {
        command = new MySqlCommand(sql, conn);
        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count != 0)
        {
            Console.WriteLine("Sid\t User Name\t Full Name\t Address\t email  ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sid = dt.Rows[i]["id"].ToString();
                string user_name = dt.Rows[i]["user_name"].ToString();
                string full_name = dt.Rows[i]["full_name"].ToString();
                string address = dt.Rows[i]["address"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                Console.WriteLine($"{sid}\t {user_name}\t {full_name}\t {address}\t {email}  ");

            }
        }

    }

    static void Main(string[] args)
    {
        UserCrud1 crud = new UserCrud1();
        try
        {
            crud.CreateConnection();

            crud.DisplayCount("select count(*) from users");

        x: Console.WriteLine("1> Insert\t 2> Update\t 3>Delete\t 4>Select");
            Console.WriteLine("Enter your choice: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string sql = "", uname = "", fname = "", address = "", email = "";
            int id = 0;
            switch (n)
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
                    sql = "insert into users (user_name,full_name,address,email) values ('" + uname + "','" + fname + "','" + address + "','" + email + "')";
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
                    sql = "update users set user_name = '" + uname + "',full_name = '" + fname + "',address = '" + address + "',email =  '" + address + "'where id = " + id;
                    crud.InsertUpdateDelete(sql);
                    break;

                case 3:
                    Console.WriteLine("Enter an id to delete: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    sql = "delete from users where id = " + id;
                    crud.InsertUpdateDelete(sql);
                    break;

                case 4:
                    sql = "select * from users";
                    crud.SelectRecords(sql);
                    break;

                default:
                    Console.WriteLine("Incorrect Choice");
                    break;

            }
            goto x;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Connection Failed !");
        }

        Console.ReadKey();

    }
}