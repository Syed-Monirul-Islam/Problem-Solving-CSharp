namespace G_Even_Hate_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int t= Convert.ToInt32(Console.ReadLine());
            while(t-->0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');
                int evenCnt = 0;
                int oddCnt = 0;

                for(int i=0; i<n; i++)
                {
                    int num = Convert.ToInt32(input[i]);
                    if (num % 2 == 0) evenCnt++;
                    else oddCnt++;
                }
                if(n% 2!=0)
                {
                    Console.WriteLine(-1);

                }
                else
                {
                    int ans = Math.Abs(evenCnt - oddCnt) / 2;
                        Console.WriteLine(ans);
                }
            }
        }
    }
}
