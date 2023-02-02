namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int tnumber = 5;//size of top of diamond
            int lnumber = 4;//size of bottom of diamond
            int Start = tnumber;
            int Mid = 1;
            for (int i = 0; i < tnumber; i++)
            {
                String line = "";
                for (int b = 0; b < Start; b++)
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
            Mid -= 4;
            Start += 2;
            for (int i = 0; i < lnumber; i++)
            {
                String line = "";
                for (int b = 0; b < Start; b++)
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
                Mid -= 2;
                Start += 1;
            }

        }
    }
}