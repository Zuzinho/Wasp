namespace WASP
{
    public class ThirdTask
    {
        public static void work()
        {
            Console.WriteLine("First ex");
            _exOne();
            Console.WriteLine("Second ex");
            _exTwo();
            Console.WriteLine("Third ex");
            _exThree();
        }

        private static void _exOne()
        {
            Console.Write("Enter length of vector: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter p-form: ");
            int p = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                result += Math.Pow(Convert.ToInt32(Console.ReadLine()),p);
            }
            result = Math.Pow(result, 1.0 / p);
            Console.WriteLine(result);
        }
        private static void _exTwo()
        {

            Console.Write("Enter length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter index of minimum: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int min = _sort(array)[k-1];
            Console.WriteLine("\n"+min);
        }
        private static void _exThree()
        {
            Console.Write("Enter length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter format: ");
            string[] format = Console.ReadLine().Split(':');
            int start = Convert.ToInt32(format[0]);
            int end = Convert.ToInt32(format[1]);
            int step = Convert.ToInt32(format[2]);
            if (step < 0)
            {
                _swap(ref start, ref end);
            }
            for(int i = start; i != end + step; i+=step)
            {
                Console.Write(array[i] + " ");
                if ((end - i) * (end - i - step) < 0) break;
            }
        }
        private static int[] _sort(int[] array)
        {
            int[] sortedArray = array;
            for(int i = 0; i < sortedArray.Length - 1; i++)
            {
                for(int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[j] < sortedArray[i])
                    {
                        _swap(ref sortedArray[i],ref sortedArray[j]);
                    }
                }
            }
            return sortedArray;
        }
        private static void _swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
