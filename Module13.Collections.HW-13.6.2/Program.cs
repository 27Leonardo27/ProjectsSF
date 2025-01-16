namespace Module13.Collections.HW_13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\12dol\\OneDrive\\Рабочий стол\\input.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            var words = new Dictionary<string, int>();

            foreach (var word in noPunctuationText.Split(" "))
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            var result = words.OrderByDescending(x => x.Value).First();

            Console.WriteLine($"Максимально повтоярется: {result.Key} - Количество: {result.Value}");
            Console.ReadLine();
        }
    }
}
