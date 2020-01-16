using System;
using System.Collections.Generic;

namespace VogCodeChallenge.Con
{
    public class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            // this is foreach  - well-known functionalities in C#.
            //foreach (string name in NamesList)
            //{
            //    Console.WriteLine(name);
            //}

            // another way using foreach - well-known functionalities in C#.

            NamesList.ForEach(name => Console.WriteLine(name));
        }
    }
}
