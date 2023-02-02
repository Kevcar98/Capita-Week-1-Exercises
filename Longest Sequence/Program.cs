namespace Longest_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            int count = 0;
            int Precount = 0;

            for (int i=0;i<sales.Length;i++) //sales.Length is the size of the sales array
            {
                if (sales[i]==0)
                {
                    count++;//increments by 1
                }
                else 
                {
                    if (Precount<count)
                    {
                        Precount = count;
                    }
                    else
                    {
                        count = 0;
                    }

                    
                    
                }
            }

            Console.WriteLine("The longest days without sales is: "+ Precount);
        }
    }
}