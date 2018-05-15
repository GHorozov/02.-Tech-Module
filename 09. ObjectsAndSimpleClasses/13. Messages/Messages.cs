using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }
    }
    class Messages
    {
        static void Main()
        {
            var users = new List<User>();
            var line = Console.ReadLine();

            while (line != "exit")
            {
                var lineArgs = line.Split(' ');

                if (lineArgs[0] == "register")
                {
                    var newUser = new User
                    {
                        Username = lineArgs[1],
                        ReceivedMessages = new List<Message>()
                    };

                    users.Add(newUser);
                }
                else
                {
                    var senderName = lineArgs[0];
                    var recepientUsername = lineArgs[2];

                    var newMessage = new Message();
                    newMessage.Content = lineArgs[3];
                    newMessage.Sender = new User() { Username = senderName, ReceivedMessages = new List<Message>() };

                    var ifConstainsSender = users.Where(x => x.Username == senderName).ToArray();
                    var ifConstainsRecipient = users.Where(x => x.Username == recepientUsername).ToArray();

                    if (ifConstainsSender.Count() > 0 && ifConstainsRecipient.Count() > 0)
                    {
                        User recipientMessage = users.FirstOrDefault(x => x.Username == recepientUsername);

                        if (recipientMessage != null)
                        {
                            recipientMessage.ReceivedMessages.Add(newMessage);
                        }
                    }
                }

                line = Console.ReadLine();
            }

            var lastInput = Console.ReadLine().Split(' ');
            var first = lastInput[0];
            var second = lastInput[1];

            var messagesFromFirstToSecond = users
                .Where(x => x.Username == second)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == first)
                .Count();
            var messagesFromSecondToFirst = users
                .Where(x => x.Username == first)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == second)
                .Count();

            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages"); return;
            }
            for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
            {
                if (i < messagesFromFirstToSecond)
                {
                    Console.WriteLine($"{first}: {users.Where(x => x.Username == second).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == first).Select(x => x.Content).ToList()[i]}");
                }
                if (i < messagesFromSecondToFirst)
                {
                    Console.WriteLine($"{users.Where(x => x.Username == first).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == second).Select(x => x.Content).ToList()[i]} :{second}");
                }
            }
        }
    }
}
