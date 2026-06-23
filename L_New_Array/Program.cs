namespace L_New_Array
{
    internal class Program
    {
        static void PrintNewArray(List<int> a,List<int> b,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(b[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrayA = Console.ReadLine().Split(' ');
            List<int> a = new List<int>();
            for(int i=0;i<n; i++)
            {
                a.Add(int.Parse(arrayA[i]));
            }

            string[] arrayB = Console.ReadLine().Split(' ');
            List<int> b = new List<int>();
            for (int i = 0; i < n; i++)
            {
                b.Add(int.Parse(arrayB[i]));
            }
            PrintNewArray(a, b, n);
        }
    }
}
