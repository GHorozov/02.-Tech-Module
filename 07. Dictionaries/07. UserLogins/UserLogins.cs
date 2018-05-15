using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class UserLogins
    {
        static void Main()
        {
            var userList = new Dictionary<string, string>();

            var line = Console.ReadLine();
            while (line != "login")
            {
                var currentUser = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = currentUser[0];
                var password = currentUser[1];

                if (!userList.ContainsKey(userName))
                {
                    userList[userName] = string.Empty;
                }

                userList[userName] = password;

                line = Console.ReadLine();
            }

            var counter = 0;
            line = Console.ReadLine();
            while (line != "end")
            {
                var currentUser = line.Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var userName = currentUser[0];
                var password = currentUser[1];

                if (userList.ContainsKey(userName) && userList[userName] == password)
                {
                    Console.WriteLine("{0}: logged in successfully", userName.Trim());
                }
                else if(!userList.ContainsKey(userName) || userList[userName] != password)
                {
                    counter++;
                    Console.WriteLine("{0}: login failed", userName.Trim());
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
