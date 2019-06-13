namespace _10._SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniCoursePlanning
    {
        public static void Main()
        {
            List<string> lesions = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] tokens = command.Split(":").ToArray();

                if (tokens[0] == "Add")
                {
                    if (!lesions.Contains(tokens[1]))
                    {
                        lesions.Add(tokens[1]);
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    if (!lesions.Contains(tokens[1]))
                    {
                        int index = int.Parse(tokens[2]);
                        lesions.Insert(index, tokens[1]);
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string exercise = tokens[1] + "-Exercise";
                    if (lesions.Contains(tokens[1]))
                    {
                        lesions.Remove(tokens[1]);
                        lesions.Remove(exercise);
                    }
                }
                else if (tokens[0] == "Swap")
                {
                    if (lesions.Contains(tokens[1]) && lesions.Contains(tokens[2]))
                    {
                        string lesionOne = tokens[1];
                        string lesionTwo = tokens[2];
                        string exerciseOne = tokens[1] + "-Exercise";
                        string exerciseTwo = tokens[2] + "-Exercise";
                        int indexOne = lesions.IndexOf(lesionOne);
                        int indexTwo = lesions.IndexOf(lesionTwo);
                        lesions.Insert(indexOne, lesionTwo);
                        lesions.RemoveAt(indexOne + 1);
                        lesions.Insert(indexTwo, lesionOne);
                        lesions.RemoveAt(indexTwo + 1);
                        if (lesions.Contains(exerciseTwo))
                        {
                            int index = lesions.IndexOf(exerciseTwo);
                            lesions.Insert(indexOne + 1, exerciseTwo);
                            lesions.RemoveAt(index + 1);
                        }

                        if (lesions.Contains(exerciseOne))
                        {
                            int index = lesions.IndexOf(exerciseOne);
                            lesions.Insert(indexTwo + 1, exerciseOne);
                            lesions.RemoveAt(index + 1);
                        }
                    }
                }
                else if (tokens[0] == "Exercise")
                {
                    string exercise = tokens[1] + "-Exercise";
                    if (lesions.Contains(tokens[1]) && !lesions.Contains(exercise))
                    {
                        int index = lesions.IndexOf(tokens[1]);
                        lesions.Insert(index + 1, exercise);
                    }
                    else if (!lesions.Contains(tokens[1]))
                    {
                        lesions.Add(tokens[1]);
                        lesions.Add(exercise);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lesions.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lesions[i]} ");
            }
        }
    }
}
