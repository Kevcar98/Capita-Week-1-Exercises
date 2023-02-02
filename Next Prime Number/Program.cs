namespace Next_Prime_Number
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
            Console.WriteLine("Enter a number to find the next prime number:");
            try
            {
                int onum = int.Parse(Console.ReadLine());
                int num = onum+1;

                while(isPrime(num)==false)
                {
                    num++;
                }
                Console.WriteLine("The next prime number after " + onum + " is " + num);

            }
            catch (Exception FormatException)
            {
                Console.WriteLine($"Unable to parse make sure you entered an integer!");
            }
        }
    }
}