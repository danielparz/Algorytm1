using System.Text;

namespace Algorytm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseString = args[0].ToString();
            List<string> substrings = new List<string>();

            for(int i = 0; i < baseString.Length; i++)
            {
                for(int j = 0; j < baseString.Length - i; j++)
                {
                    substrings.Add(baseString.Substring(i, j + 1));
                }
            }

            foreach(var substring in substrings)
                Console.WriteLine(substring);
        }
    }
}