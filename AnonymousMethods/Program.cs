using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addAnonymous = delegate (int firstNum, int secondNum)
            {
                return (firstNum + secondNum);
            };

            CalculateSum(addAnonymous);

            Func<int, int, int> subAnonymous = delegate (int firstNum, int secondNum)
            {
                return (firstNum - secondNum);
            };

            CalculateDifference(subAnonymous);

            Func<int, int, int> mulAnonymous = delegate (int firstNum, int secondNum)
            {
                return (firstNum * secondNum);
            };

            CalculateProduct(mulAnonymous);

            Func<int, int, int> divAnonymous = delegate (int firstNum, int secondNum)
            {
                return (firstNum / secondNum);
            };

            CalculateReminder(divAnonymous);
        }
        static void CalculateSum(Func<int, int, int> func)
        {
            Console.WriteLine($"Sum is : {func(170,34)}");

        }
        static void CalculateDifference(Func<int, int, int> func)
        {
            Console.WriteLine($"Difference is : {func(140, 72)}");

        }
        static void CalculateProduct(Func<int, int, int> func)
        {
            Console.WriteLine($"Product is : {func(16, 72)}");

        }
        static void CalculateReminder(Func<int, int, int> func)
        {
            Console.WriteLine($"Reminder is : {func(140, 42)}");

        }
    }
}
