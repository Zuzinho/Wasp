namespace WASP
{
    public class SecondTask
    {
        public static void work()
        {
            Console.WriteLine("First ex");
            _exOne();
            Console.WriteLine("Second ex");
            _exTwo();
            Console.WriteLine("Third ex");
            _exThree();
            Console.WriteLine("Fourth ex");
            _exFour();
            Console.WriteLine("Fifth ex");
            _exFive();
        }

        private static void _exOne()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string number = _convert(n);
            Console.WriteLine(n + " -> " + number);
        }
        private static void _exTwo()
        {
            int first, second, result;
            Console.Write("Enter first operand: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second operand: ");
            second = Convert.ToInt32(Console.ReadLine());
            result = first + second;
            string firstStr = _convert(first), secondStr = _convert(second), resultStr = _convert(result);
            int len = resultStr.Length;
            while (firstStr.Length < len) firstStr = "0" + firstStr;
            while (secondStr.Length < len) secondStr = "0" + secondStr;
            Console.WriteLine(firstStr + '\n' + secondStr + "\n\n" + resultStr);
        }
        private static void _exThree()
        {
            Console.Write("Enter 4 numbers: ");
            short first = Convert.ToInt16(Console.ReadLine());
            short second = Convert.ToInt16(Console.ReadLine());
            short third = Convert.ToInt16(Console.ReadLine());
            short fourth = Convert.ToInt16(Console.ReadLine());
            long result = 0;
            long maska = fourth;
            maska <<= 48;
            result |= maska;
            maska = third;
            maska <<= 32;
            result |= maska;
            maska = second;
            maska <<= 16;
            result |= maska;
            maska = first;
            result |= maska;
            Console.WriteLine(result);
        }
        private static void _exFour()
        {
            Console.Write("Enter number: ");
            long number = Convert.ToInt64(Console.ReadLine());
            short fourth = (short)(number >> 48);
            short third = (short)(number >> 32);
            short second = (short)(number >> 16);
            short first = (short)number;
            Console.WriteLine(first + " " + second + " " + third + " " + fourth);

        }
        private static void _exFive()
        {
            Console.Write("Enter number: ");
            long n = Convert.ToInt64(Console.ReadLine());
            int m, k;
            Console.WriteLine("Enter indexes of bytes: ");
            m = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            byte mByte = (byte)(n >> (m - 1) * 8);
            byte kByte = (byte)(n >> (k - 1) * 8);
            long maska = 255 << (m - 1) * 8;
            n &= ~maska;
            maska = 255 << (k - 1) * 8;
            n &= ~maska;
            n |= mByte << ((k - 1) * 8);
            n |= kByte << ((m - 1) * 8);
            Console.WriteLine(n);
        }
        private static string _convert(int a)
        {
            string number = "";
            uint n = (uint)a;
            int count = (int)(Math.Log2(n)) + 1;
            while(count > 0)
            {
                number += ((n << 31 - --count) >> 31).ToString();
            }
            return number;
        }
    }
}
