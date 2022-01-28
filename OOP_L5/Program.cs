
namespace OOP_L5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Ratio(1, 2) == new Ratio(1,4) );
            Console.WriteLine(new Ratio(1, 2) == null);

            var a = new Ratio(1, 2) == new Ratio(1,4);
        }
    }
}