namespace ExporableAreasConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adventure adventure = new Adventure();
            Console.Title = adventure.Name;

            //transfer program flow
            //exection flow
            adventure.SetUp();
            Console.ReadKey();
        }
    }
}
