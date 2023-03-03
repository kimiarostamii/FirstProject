namespace Test01
{
    class Greeter
    {
        public static void Run()
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Greet(name);

        }
        private static void Greet(string name)
        {
            Console.WriteLine("Hello " + name + ", how are you?");
        }
    }
}