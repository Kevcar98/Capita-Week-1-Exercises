namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            

            
            List<int> TSlist = new List<int>()
            {
                3,1,5,7,5,9,10
            };
            Console.WriteLine("Enter a number from 0 to " + (TSlist.Count-1));
            String SVal1 = Console.ReadLine();
            Console.WriteLine("Enter a second number from 0 to "+(TSlist.Count-1));
            String SVal2 = Console.ReadLine();

            try
            {
                int Val1 = int.Parse(SVal1);
                int Val2 = int.Parse(SVal2);
                (int, int) Tval = (Val1,Val2);

                int P1 = TSlist[Tval.Item1];
                //Console.WriteLine(P1);
                int P2 = TSlist[Tval.Item2];
                //Console.WriteLine(P2);
                int ans = P1+P2;
                Console.WriteLine("The sum of the two numbers in the list is: "+ans);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{SVal1} or {SVal2}' make sure they are both an integer!");
            }               
        }
    }
}