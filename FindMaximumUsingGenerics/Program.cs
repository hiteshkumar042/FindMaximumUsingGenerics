namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //UC1 - Maximum int Number
            //Test Case 1 - Max Number at first position and return same. 
            int maxInt = FindMaximum.FindIntMaximum(32,18,11);
            Console.WriteLine("Maximum Numbe is : " + maxInt);
        }
    }
}