using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Azgreial!\nPlease create your character.\n");


            Console.WriteLine("What will your name be?\n");

            var name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What race do you choose?\n");

            var race = Console.ReadLine();

            Console.WriteLine();


            Console.WriteLine("What class will you choose?\n");

            var @class = Console.ReadLine();

            Console.WriteLine();


            Console.WriteLine("What is your companions name?\n");

            var companions = Console.ReadLine();

            Console.WriteLine();



            Console.WriteLine("And on with your story!\n");

            
            Console.WriteLine($"{companions} nudges on you the shoulder,{name} we are here. You awaken still in the " +
                              $"cart\nas it is bumping down the " +
                              $"dirt road. You are pleased at the sight of\nthe {race} city." +
                              $" Now it is time to find your {@class} masters and let them know of the situation up north.");
        }
    }
}
