namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //UC1 - Maximum int Number
            //Test Case 1 - Max Number at first position and return same. 
            int max1stInt = FindMaximum.FindIntMaximum(32,18,11);
            Console.WriteLine("Maximum Number for 1st test Case is : " + max1stInt);
            //Test Case 1 - Max Number at Second position and return same. 
            int max2ndInt = FindMaximum.FindIntMaximum(18, 32, 11);
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndInt);
        }
    }
}