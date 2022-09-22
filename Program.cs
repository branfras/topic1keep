using System;

namespace topic1keep
{
    class Program
    {
        static void Main(string[] args)
        {
            // brandon f
            string firstName = "Brandon";
            string favMovie = "The Matrix";
            string movQuote = "You shall not pass";
            Console.WriteLine($"greetings {firstName.ToLower()}. your favourite movie is {favMovie.ToLower()}.");
            favMovie = favMovie.Replace(favMovie, favMovie.ToUpper());
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            Console.WriteLine(" ");
            movQuote = movQuote.Replace("o", " ");
            movQuote = movQuote.Replace("u", " ");
            movQuote = movQuote.Replace("a", " ");
            Console.WriteLine(movQuote);
            Console.WriteLine(" ");
            Console.WriteLine("                   o           ");
            Console.WriteLine("           o       /           ");
            Console.WriteLine("            \\     /            ");
            Console.WriteLine("             \\   /             ");
            Console.WriteLine("              \\ /              ");
            Console.WriteLine("+--------------v-------------+ ");
            Console.WriteLine("|  __________________      @ | ");
            Console.WriteLine("| /                  \\       | ");
            Console.Write("| |             ,--, |  (\\)  | ");
            Console.WriteLine(" __           __  ");
            Console.Write("| |       _ ___/ /\\| |       | ");
            Console.WriteLine("(  `.       ,`  ) ");
            Console.Write("| |   ,;`( )__, )  ~ |  (-)  | ");
            Console.WriteLine(" `.__\\_ _ _/__,'  ");
            Console.Write("| |  // o//   '--;   |       | ");
            Console.WriteLine("    ;(*) (*);     ");
            Console.Write("| \\  ' o \\     |     / :|||: | ");
            Console.WriteLine("    ;  \\ /  ;     ");
            Console.Write("|  -ooo--------------  :|||: | ");
            Console.WriteLine("     ;  o  ;      ");
            Console.Write("+----------------------------+ ");
            Console.WriteLine(" ,---'.`-','---.  ");
            Console.Write("   []                    []    ");
            Console.WriteLine(" |  |  `\"'  |  |  ");
        }
    }
}
