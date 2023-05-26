using System.Diagnostics;
internal class Task1
 {
     static void Main(string[] args)
        {
            var WatchOne = Stopwatch.StartNew();
            var strings = new List<string>();
            string text = File.ReadAllText("C:\\Users\\ridzh\\Documents\\Text1.txt");
            strings.Add(text);
            Console.WriteLine($"Вставка в List: {WatchOne.Elapsed.TotalMilliseconds} мс");
           
            var WatchTwo = Stopwatch.StartNew();
            LinkedList<string> LinkedList = new LinkedList<string>();
            text = File.ReadAllText("C:\\Users\\ridzh\\Documents\\Text1.txt");
            LinkedList.AddFirst(text);
            Console.WriteLine($"Вставка в LinkedList: {WatchTwo.Elapsed.TotalMilliseconds} мс");
        }
}
