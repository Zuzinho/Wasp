namespace WASP
{
    public class FirstTask
    {
        public static void work()
        {
            Console.WriteLine("First ex");
            _exOne();
            Console.WriteLine("Second ex");
            _exTwo();
            //Console.WriteLine("Third ex");
            //_exThree();
            Console.WriteLine("Fourth ex");
            _exFour();
        }

        private static void _exOne()
        {
            for (int first = 3; first < 10; first++)
            {
                for (int second = 2; second < first; second++)
                {
                    for (int third = 1; third < second; third++)
                    {
                        for (int fourth = 0; fourth < third; fourth++)
                        {
                            Console.WriteLine(first * 1000 + second * 100 + third * 10 + fourth);
                        }
                    }
                }
            }
        }
        private static void _exTwo()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int count = n - i;
                int summand = 1;
                for (int j = 0; j < n; j++)
                {
                    Console.Write(count + " ");
                    if (count == n) summand = -1;
                    count += summand;
                }
                Console.WriteLine();
            }
        }
        private static void _exFour()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 3;
            int[] values = { 0, 1, 0 };
            for (int i = 0; i < n; i++)
            {
                count += 1;
                int[] newValues = new int[count];
                for (int j = 0; j < count - 2; j++)
                {
                    int number = values[j] + values[j + 1];
                    newValues[j + 1] = number;
                    if (values[j + 1] != 0) Console.Write(values[j + 1] + " ");
                }
                values = newValues;
                Console.WriteLine();
            }
        }
    }
}
