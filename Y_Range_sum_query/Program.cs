namespace Y_Range_sum_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {

                string[] firstLine = reader.ReadLine().Split(' ');
                int n = int.Parse(firstLine[0]);
                int q = int.Parse(firstLine[1]);

                string[] elements = reader.ReadLine().Split(' ');

                List<long> v = new List<long>(new long[n+1]);
                for(int i=1;i<=n;i++)
                {
                    v[i] = long.Parse(elements[i - 1]);
                }

                List<long> pre = new List<long>(new long[n + 1]);
                pre[1] = v[1];
                for(int i=2;i<=n;i++)
                {
                    pre[i] = pre[i-1] + v[i];

                }

                while(q-->0)
                {
                    string[] query = reader.ReadLine().Split(' ');
                    int l = int.Parse(query[0]);
                    int r = int.Parse(query[1]);
                    long sum;
                    if(l==1)
                    {
                        sum = pre[r];
                    }
                    else
                    {
                        sum = pre[r] - pre[l - 1];
                    }
                    writer.WriteLine(sum);
                }

            }
        }
    }
}
