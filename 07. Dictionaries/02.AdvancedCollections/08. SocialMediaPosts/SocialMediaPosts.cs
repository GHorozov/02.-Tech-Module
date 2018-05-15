using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class SocialMediaPosts
    {
        static void Main(string[] args)
        {
            var postNameLikes = new Dictionary<string, int>();
            var postNameDislikes = new Dictionary<string, int>();
            var postNameComments = new Dictionary<string, Dictionary<string, string>>();
            ReadAndAddData(postNameLikes, postNameDislikes, postNameComments);
            PrintResult(postNameLikes, postNameDislikes, postNameComments);

        }

        private static void PrintResult(Dictionary<string, int> postNameLikes, Dictionary<string, int> postNameDislikes, Dictionary<string, Dictionary<string, string>> postNameComments)
        {
            foreach (var post in postNameLikes)
            {
                Console.Write("Post: {0} | Likes: {1} | ", post.Key, post.Value);

                if (postNameDislikes.ContainsKey(post.Key))
                {
                    Console.WriteLine("Dislikes: {0}", postNameDislikes[post.Key]);
                }
                else
                {
                    Console.WriteLine("Dislikes: 0");
                }

                if (!postNameComments.ContainsKey(post.Key))
                {
                    Console.WriteLine("Comments:");
                    Console.WriteLine("None");
                }

                if (postNameComments.ContainsKey(post.Key))
                {
                    Console.WriteLine("Comments:");
                    foreach (var itemKey in postNameComments)
                    {
                        if (itemKey.Key == post.Key)
                        {
                            foreach (var item in itemKey.Value)
                            {
                                var nameOfCommentator = item.Key;
                                var comment = item.Value;
                                Console.WriteLine("*  {0}: {1}", nameOfCommentator, comment);
                            }
                        }
                    }
                }
            }
        }

        private static void ReadAndAddData(Dictionary<string, int> postNameLikes, Dictionary<string, int> postNameDislikes, Dictionary<string, Dictionary<string, string>> postNameComments)
        {
            var line = Console.ReadLine();
            while (line != "drop the media")
            {
                var currentLine = line.Split(' ');
                var command = currentLine[0];

                if (command == "post")
                {
                    var name = currentLine[1];

                    if (!postNameLikes.ContainsKey(name))
                    {
                        postNameLikes[name] = 0;
                    }
                }
                else if (command == "like")
                {
                    var name = currentLine[1];

                    if (postNameLikes.ContainsKey(name))
                    {
                        postNameLikes[name] += 1;
                    }

                }
                else if (command == "dislike")
                {
                    var name = currentLine[1];

                    if (postNameLikes.ContainsKey(name))
                    {
                        if (!postNameDislikes.ContainsKey(name))
                        {
                            postNameDislikes[name] = 0;
                        }

                        postNameDislikes[name] += 1;
                    }

                }
                else if (command == "comment")
                {
                    var name = currentLine[1];
                    var commentatorName = currentLine[2];
                    var comment = "";
                    if (currentLine.Length > 4)
                    {
                        comment = "";
                        for (int i = 3; i < currentLine.Length; i++)
                        {
                            comment += currentLine[i] + " ";
                        }
                    }
                    else
                    {
                        comment = currentLine[3];
                    }


                    if (postNameLikes.ContainsKey(name))
                    {
                        if (!postNameComments.ContainsKey(name))
                        {
                            postNameComments[name] = new Dictionary<string, string>();
                        }

                        postNameComments[name][commentatorName] = comment;
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}
