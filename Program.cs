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
            Greeter.Run();
        }

    }
}