namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //Refactor 1 - Combine al Three type of Find max

            //Intergers : Test case 1 - Max at First Position 
            int max1Int = FindMaximum.FindingMaximum(40,33,28);
            Console.WriteLine("Maximum Number for 1st int test Case is : " + max1Int);
            //Intergers : Test case 2 - Max at Second Position 
            int max2Int = FindMaximum.FindingMaximum(28, 40, 33);
            Console.WriteLine("Maximum Number for 2nd int test Case is : " + max2Int);
            //Intergers : Test case 3 - Max at third Position 
            int max3Int = FindMaximum.FindingMaximum(28, 33, 40);
            Console.WriteLine("Maximum Number for 3rd int test Case is : " + max3Int);

            //Float :  Test case 1 - Max at First Position 
            double max1Float = FindMaximum.FindingMaximum(40.23,20.34,35.45);
            Console.WriteLine("\nMaximum Number for 1st float test Case is : " + max1Float);
            //Float : Test case 2 - Max at Second Position 
            double max2Float = FindMaximum.FindingMaximum(20.34, 40.23, 35.45);
            Console.WriteLine("Maximum Number for 2nd float test Case is : " + max2Float);
            //Float : Test case 3 - Max at third Position 
            double max3Float = FindMaximum.FindingMaximum(20.34, 35.45, 40.23);
            Console.WriteLine("Maximum Number for 3rd float test Case is : " + max3Float);


            //String : Test Case 1 - Max at First Postion
            String max1String = FindMaximum.FindingMaximum("Peach", "Apple","Banana");
            Console.WriteLine("\nMaximum Number for 1st string test Case is : " + max1String);
            //String : Test Case 2 - Max at Second Postion
            String max2String = FindMaximum.FindingMaximum("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum Number for 2nd String test Case is : " + max2String);
            //String : Test Case 3 - Max at Third Postion
            String max3String = FindMaximum.FindingMaximum("Banana", "Apple", "Peach");
            Console.WriteLine("Maximum Number for 3rd String test Case is : " + max3String);
        }
    }
}