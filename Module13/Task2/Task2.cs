   internal class Task2
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\ridzh\\Documents\\Text1.txt"); 
            var noPunctualitenText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] nocount = { ' ', '\r', '\t' }; 
            var words = noPunctualitenText.Split(nocount, StringSplitOptions.RemoveEmptyEntries);
            var RepWords = new Dictionary<string, int>();
            int show = 0;

            foreach (var word in words)
            {
                bool rep = RepWords.ContainsKey(word); 
                int count;

                if (rep is true)  
                {
                    RepWords.TryGetValue(word, out count);
                    RepWords.Remove(word);
                    RepWords.Add(word, count + 1);
                }

                else
                {
                    RepWords.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> word in RepWords.OrderByDescending(key => key.Value))
            {
                if (show < 10)
                {
                    Console.WriteLine($"Слово {word.Key} упоминалось {word.Value} раз");
                    show++;
                }
            }
            Console.ReadLine();
        }
    }