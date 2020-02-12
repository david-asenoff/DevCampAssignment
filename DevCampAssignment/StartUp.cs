using DevCampAssignment;
using System;

namespace MentorMateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Constants.InvalidWidthRange}");
            Console.WriteLine($"{Constants.InvalidCharacter}");
            Console.WriteLine($"{Constants.InvalidSpace}");

            while (true)
            {
                try
                {
                    Console.Write($"Please enter width:");
                    var width = int.Parse(Console.ReadLine());


                    Console.Write($"Please enter main symbol:");
                    var character = char.Parse(Console.ReadLine());


                    Console.Write($"Please enter space symbol:");
                    var space = char.Parse(Console.ReadLine());

                    var logo = new MMLogo(character, space, width);
                    var result = logo.GetString();
                    Console.WriteLine(result);
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}