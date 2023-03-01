namespace task_array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 55, 79, 38, 22, 106 };
            int cem = 0;
            int say = 0;
            for (int i = 0; i < a.Length; i++)
            {
                say++;
                cem += a[i];
            }
            Console.WriteLine(cem / say);
        }
    }
}