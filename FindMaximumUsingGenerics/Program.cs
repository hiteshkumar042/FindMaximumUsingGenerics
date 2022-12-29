namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //UC2 - Maximum Float Number
            //Test Case 1 - Max Number at first position and return same. 
            double max1stDouble = FindMaximum.FindDoubleMaximum(55.85,42.45,23.25);
            Console.WriteLine("Maximum Number for 1st test Case is : " + max1stDouble);
            //Test Case 2 - Max Number at Second position and return same. 
            double max2ndDouble = FindMaximum.FindDoubleMaximum(42.45, 55.85, 23.25);
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndDouble);
            //Test Case 3 - Max Number at Third position and return same. 
            double max3rdDouble = FindMaximum.FindDoubleMaximum(23.25, 42.45, 55.85);
            Console.WriteLine("Maximum Number for 3rd test Case is : " + max3rdDouble);
        }
    }
}