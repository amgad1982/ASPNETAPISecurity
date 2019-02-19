using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Login press 1, New User press 2");
            var selection = Console.ReadLine();
            switch(selection)
            {
                case "1":
                    break;
                case "2":
                    break;
            }
        }
    }

    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserLogin()
        {
            

        }

        public void CreateLogin()
        {
            Console.WriteLine("User Name:");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Password:");
            this.Password = Console.ReadLine();
            this.Authenticate();
        }
        public void Authenticate()
        {
            if(!string.IsNullOrEmpty(this.UserName)&&!string.IsNullOrEmpty(this.Password))
            {
                var client = new RestClient("http://localhost:49750/token");
                client.AddDefaultHeader("Content-Type", "application/x-www-form-urlencoded");

            }
            else
            {
                Console.WriteLine("Please provide login credentials");
                this.CreateLogin();
            }
        }
    }
}
