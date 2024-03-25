using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_List
{
    internal class User
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Username;
        public string Password;


        public static int Register(List<User> list)
        {
            User u = new User();

            Random r = new Random();
            u.Id = r.Next(100000, 999999);
            Console.WriteLine("Name:");
            u.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            u.Surname = Console.ReadLine();
            Console.WriteLine("Username:");
            u.Username = Console.ReadLine();
            Console.WriteLine("Password:");
            string pass = Console.ReadLine();
            Console.WriteLine("RePassword:");
            string repass = Console.ReadLine();

            if (repass == pass)
            {
                u.Password = pass;
                list.Add(u);
                return 1;
            }
            else
            {
                return -100;
            }
        }

        public static User Login(string username,string password,List<User> list)
        {
            foreach (var item in list)
            {
                if(item.Username==username && item.Password == password)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
