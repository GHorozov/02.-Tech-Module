using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterUsers
{
    class RegisterUsers
    {
        static void Main()
        {
            var users = new Dictionary<string, DateTime>();
            var line = Console.ReadLine();
            while(line != "end")
            {
                var lineArgs = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = lineArgs[0];
                var dateString = lineArgs[1];
                var date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if(!users.ContainsKey(userName))
                {
                    users[userName] = new DateTime();
                }

                users[userName] = date;

                line = Console.ReadLine();
            }

            var lastFiveReg = users.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=>x.Value);

            foreach (var user in lastFiveReg)
            {
                Console.WriteLine("{0}", user.Key);
            }
        }
    }
}
