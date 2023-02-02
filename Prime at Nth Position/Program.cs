namespace Prime_at_Nth_Position
{
    internal class Program
    {

        public static bool isPrime(int num)
        {
            int counter = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int num = 2;
            Console.WriteLine("Enter the nth number up to 100");
            try
            {
                int n = int.Parse(Console.ReadLine());
                List<int> PrimeNumL = new List<int>();
                while (PrimeNumL.Count!=n)
                {
                    if (isPrime(num))
                    {
                        PrimeNumL.Add(num);
                    }
                    num++;
                }
                Console.WriteLine("The prime number in postion " + (n) + " is " + PrimeNumL[n-1]);
            }
            catch (Exception FormatException)
            {
                Console.WriteLine($"Unable to parse make sure you entered an integer!");
            }
        }
    }
}