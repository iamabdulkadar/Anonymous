using System;

namespace ActionAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> addAction = delegate (int firstNum, int secondNum)
            {
                Console.WriteLine($"Sum is : {firstNum + secondNum}");
            };
            Action<int, int> subAction = delegate (int firstNum, int secondNum)
            {
                Console.WriteLine($"Difference is : {firstNum - secondNum}");
            };
            Action<int, int> mulAction = delegate (int firstNum, int secondNum)
            {
                Console.WriteLine($"Product is : {firstNum * secondNum}");
            };
            Action<int, int> divAction = delegate (int firstNum, int secondNum)
            {
                Console.WriteLine($"Reminder is : {firstNum / secondNum}");
            };
            addAction(150, 75);
            subAction(75, 42);
            mulAction(58, 4);
            divAction(840, 42);

            Console.ReadKey();
        }
    }
}
