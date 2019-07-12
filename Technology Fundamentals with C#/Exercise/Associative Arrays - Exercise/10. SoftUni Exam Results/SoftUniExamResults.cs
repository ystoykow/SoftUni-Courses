namespace _10._SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniExamResults
    {
        public static void Main()
        {
            SortedDictionary<string, int> userPoints = new SortedDictionary<string, int>();
            SortedDictionary<string, int> langCounter = new SortedDictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] token = input.Split("-");
                string user = token[0];
                string lang = token[1];
                if (lang == "banned" && userPoints.ContainsKey(user))
                {
                    userPoints.Remove(user);
                    input = Console.ReadLine();
                    continue;
                }

                int points = int.Parse(token[2]);
                if (!userPoints.ContainsKey(user))
                {
                    userPoints.Add(user, points);
                }
                else if (userPoints.ContainsKey(user))
                {
                    if (points > userPoints[user])
                    {
                        userPoints[user] = points;
                    }
                }

                if (!langCounter.ContainsKey(lang))
                {
                    langCounter.Add(lang, 0);
                }

                langCounter[lang]++;
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var kvp in userPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in langCounter.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
