namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics!");
            //Refactor 1 - Combine al Three type of Find max

            //Intergers : Test case 1 - Max at First Position 
            int max1Int = FindMaximum<int>.testMaximum(40,33,28,33,66);
            Console.WriteLine("Maximum Number for 1st int test Case is : " + max1Int);
            //Intergers : Test case 2 - Max at Second Position 
            int max2Int = FindMaximum<int>.testMaximum(28, 40, 33,33,66);
            Console.WriteLine("Maximum Number for 2nd int test Case is : " + max2Int);
            //Intergers : Test case 3 - Max at third Position 
            int max3Int = FindMaximum<int>.testMaximum(28, 33, 40,33,66);
            Console.WriteLine("Maximum Number for 3rd int test Case is : " + max3Int);

            //Float :  Test case 1 - Max at First Position 
            double max1Float = FindMaximum<double>.testMaximum(40.23,20.34,35.45,20.44,44.56);
            Console.WriteLine("\nMaximum Number for 1st float test Case is : " + max1Float);
            //Float : Test case 2 - Max at Second Position 
            double max2Float = FindMaximum<double>.testMaximum(20.34, 40.23, 35.45, 20.44, 44.56);
            Console.WriteLine("Maximum Number for 2nd float test Case is : " + max2Float);
            //Float : Test case 3 - Max at third Position 
            double max3Float = FindMaximum<double>.testMaximum(20.34, 35.45, 40.23, 20.44, 44.56);
            Console.WriteLine("Maximum Number for 3rd float test Case is : " + max3Float);


            //String : Test Case 1 - Max at First Postion
            String max1String = FindMaximum<string>.testMaximum("Peach", "Apple","Banana","Papaya","Orange");
            Console.WriteLine("\nMaximum Number for 1st string test Case is : " + max1String);
            //String : Test Case 2 - Max at Second Postion
            String max2String = FindMaximum<string>.testMaximum("Apple", "Peach", "Banana","Papaya","Orange");
            Console.WriteLine("Maximum Number for 2nd String test Case is : " + max2String);
            //String : Test Case 3 - Max at Third Postion
            String max3String = FindMaximum<string>.testMaximum("Banana", "Apple", "Peach", "Papaya", "Orange");
            Console.WriteLine("Maximum Number for 3rd String test Case is : " + max3String);
        }
    }
}