using System.Text.RegularExpressions;

namespace CodeKatas
{
    public class MostFrequentlyUsedWords
    {
        public static List<string> Top3(string s)
        {
            Console.WriteLine(s);
            var dict = new Dictionary<string, int>();
            s = Regex.Replace(s, "[^a-zA-Z0-9 ']", " ");
            s = Regex.Replace(s, "'{2,}", "'");

            var list = s.Split(' ').ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var currentWord = list[i].ToLower();
                if (currentWord == " " || currentWord == "" || currentWord == "'")
                    continue;
                else if (dict.ContainsKey(currentWord))
                {
                    dict[currentWord] = dict[currentWord] + 1;
                }
                else
                {
                    dict.Add(currentWord, 1);
                }

            }
            var keyList = dict
                .ToList()
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(3)
                .ToList();



            return keyList;
        }
    }
}
