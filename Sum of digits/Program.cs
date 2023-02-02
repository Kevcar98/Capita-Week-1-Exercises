namespace Sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to find the sum of the digits:");
            String numb = Console.ReadLine();
            int sum = 0, reminder;
            try
            {
                int result = int.Parse(numb);

                while (result > 0)
                {
                    reminder = result % 10;
                    sum = sum + reminder;
                    result = result / 10;

                    
                }
                Console.WriteLine(sum);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{numb}' make sure this is an integer!");
            }

        }
    }
}