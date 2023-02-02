namespace String_Reversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text = "hello world";
            char[] charArr = text.ToCharArray();
            Array.Reverse(charArr);            
            String Ntext = String.Join("", charArr);
            Console.WriteLine(Ntext);

        }
    }
}