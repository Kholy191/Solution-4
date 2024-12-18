namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object Name1 = new object();
            Name1 = "Ahmed";
            object Name2 = new object();
            Name2 = "Mahmoud";

            Name2 = Name1;

            Console.WriteLine(Name1);
            Console.WriteLine(Name1.GetHashCode());
            Console.WriteLine(Name2);
            Console.WriteLine(Name2.GetHashCode());
            Console.WriteLine("__________");

            Name1 = "omara";
            Console.WriteLine(Name1);
            Console.WriteLine(Name1.GetHashCode());
            Console.WriteLine(Name2);
            Console.WriteLine(Name2.GetHashCode());
            Console.WriteLine("__________")
        }
    }
}
