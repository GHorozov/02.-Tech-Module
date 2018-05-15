using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace UserDatabase
{
    class UserDatabase
    {
        private static string dbPath = "users.txt";
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private static string loggedInUser = null;

        static void Main()
        {
            //Check is dabase exist if not create one.
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Close();
            }

            //==========================================================================
            // To save in dictionary previous login from first input and use them now. IF there are users with password I save all in users(dictionary).

            //First way lith linq
            //File.ReadAllLines(dbPath).Select(l =>
            //            {
            //                var parts = l.Split(' ');
            //                return new
            //                {
            //                    Username = parts[0],
            //                    Password = parts[1]
            //                };
            //            });


            //Second way.
            var dbLines = File.ReadAllLines(dbPath);

            foreach (var line in dbLines)
            {
                var linePart = line.Split(' ');
                var username = linePart[0];
                var password = linePart[1];

                users[username] = password;
            }
            //======================================================================


            var lines = File.ReadAllLines("input.txt");

            foreach (var line in lines)
            {
                if (line == "exit") break;

                var lineParts = line.Split(' ');
                var command = lineParts[0];

                if (command == "register")
                {
                    var username = lineParts[1];
                    var password = lineParts[2];
                    var confirmPassword = lineParts[3];

                    Register(username, password, confirmPassword);

                }
                else if (command == "login")
                {
                    var username = lineParts[1];
                    var password = lineParts[2];

                    Login(username, password);

                }
                else if (command == "logout")
                {
                    Logout();
                }
            }
        }

        private static void Logout()
        {
            if (loggedInUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }

            loggedInUser = null;
        }

        private static void Login(string username, string password)
        {
            if (loggedInUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }

            if (users[username] != password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }

            loggedInUser = username;
        }

        private static void Register(string username, string password, string confirmPassword)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }

            if (password != confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }

            users[username] = password;

            File.AppendAllLines(dbPath, new[] { $"{username} {password}" });
        }
    }
}
