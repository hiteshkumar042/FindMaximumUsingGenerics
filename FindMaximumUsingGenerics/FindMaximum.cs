namespace FindMaximumUsingGenerics
{
    class FindMaximum<T> where T : IComparable
    {

        // Instance variables
        public T firstValue, secondValue, thirdValue;

        // Constructor
        public FindMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        // Generic method to find maximum value
        public static T MaximumNumber(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }

        // Generic method to call maximum method
        public T MaxMethod()
        {
            T maxNumber = FindMaximum<T>.MaximumNumber(this.firstValue, this.secondValue, this.thirdValue);
            return maxNumber;
        }
    }
}
