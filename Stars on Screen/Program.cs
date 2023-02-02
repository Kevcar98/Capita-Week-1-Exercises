namespace Stars_on_Screen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;//size of pyramid
            int Start=number;
            int Mid = 1;
            for (int i = 0;i < number; i++)
            {
                String line = "";
                for (int b = 0;b < Start;b++)
                {
                    line += " ";
                }
                for (int c = 0; c < Mid; c++)
                {
                    line += "*";
                }
                for (int d = 0; d < Start; d++)
                {
                    line += " ";
                }
                Console.WriteLine(line);
                Mid += 2;
                Start -= 1;

            }



        }
    }
}