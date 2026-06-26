namespace Z_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int q = int.Parse(firstLine[1]);

            string[] elements = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(elements[i]);
            }
            Array.Sort(a);
            while(q-->0)
            {
                int val = int.Parse(Console.ReadLine());
                int flag = 0;
                int l = 0;
                int r = n - 1;

                while(l<=r)
                {
                    int mid = (l + r) / 2;
                    if (a[mid]==val)
                    {
                        flag = 1;
                        break;
                    }
                    else if (a[mid]> val)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("found");

                }
                else
                {
                    Console.WriteLine("not found");
                }

            }
           
        }
    }
}
