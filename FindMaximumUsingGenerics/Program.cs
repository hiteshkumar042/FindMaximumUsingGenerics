namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //UC3 - Maximum String
            //Test Case 1 - Max String at first position and return same. 
            String max1stString = FindMaximum.FindStringMaximum("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum Number for 1st test Case is : " + max1stString);
            //Test Case 2 - Max string at Second position and return same. 
            String max2ndString = FindMaximum.FindStringMaximum("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndString);
            //Test Case 3 - Max string at Third position and return same. 
            String max3rdString = FindMaximum.FindStringMaximum("Peach", "Banana","Apple");
            Console.WriteLine("Maximum Number for 3rd test Case is : " + max3rdString);
        }
    }
}