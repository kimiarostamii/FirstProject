namespace Test01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum, sub, mult, div;

            sum = Calculator.Add(2, 8);
            sub = Calculator.Sub(6, sum);
            Console.WriteLine($"6 - {sum} = {sub}");
            mult = Calculator.Mult(sub, 2);
            Console.WriteLine(mult);
            div = Calculator.Div(sub, 2);
            Console.WriteLine(div);
            RunGreeter();
        }


        static void RunGreeter()
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Greeter(name);

        }
        static void Greeter(string name)
        {
            Console.WriteLine("Hello " + name + ", how are you?");
        }
    }
}