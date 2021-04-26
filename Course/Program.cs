using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                                DateTime.Parse("21/06/2018 13:05:44"),
                                "Traveling to New Zealand",
                                "I'm going to visit this wonderful country!",
                                12
                );
            p1.addComment(c1);
            p1.addComment(c2);

            Console.WriteLine(p1);


        }
    }
}
