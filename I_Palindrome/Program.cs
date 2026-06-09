namespace I_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string reversed = new string(s.Reverse().ToArray());

            if (s == reversed)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
