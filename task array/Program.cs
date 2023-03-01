namespace task_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 25, 56, 112, 33, 67 };
            int cem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    cem += a[i];
                }
            }
            Console.WriteLine(cem);
        }
    }
}