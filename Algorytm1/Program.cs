using System.Text;

namespace Algorytm1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string baseString = args[0].ToString();
            string baseString = "abcd";
            List<string> list = new List<string>();

            Console.WriteLine("Wypisz wszystkie podciągi podanego ciągu:");
            list = GetAllSubstrings(baseString);
            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("Wypisz wszystkie wariacje znaków podanego ciągu:");
            list = GetAllSubcharVariations(baseString);
            foreach(var item in list)
                Console.WriteLine(item);
        }

        public static List<string> GetAllSubstrings(string baseString)
        {
            List<string> substrings = new List<string>();

            for (int i = 0; i < baseString.Length; i++)
            {
                for (int j = 0; j < baseString.Length - i; j++)
                {
                    substrings.Add(baseString.Substring(i, j + 1));
                }
            }
            return substrings;
        }

        public static List<string> GetAllSubcharVariations(string baseString)
        {
            List<string> list = new List<string>();
            List<string> strings = GetAllSubstrings(baseString);
            foreach (var item in strings)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    for (int j = 0; j < item.Length - i; j++)
                        if(!list.Contains(item.Remove(i, j + 1)))
                            list.Add(item.Remove(i, j + 1));
                }
            }

            return list;
        }
    }
}