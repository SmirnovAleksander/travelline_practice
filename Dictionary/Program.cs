public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> translator = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("### Список команд ###\n");

            Console.WriteLine("AddTranslation: 1");
            Console.WriteLine("RemoveTranslation: 2");
            Console.WriteLine("ChangeTranslation: 3");
            Console.WriteLine("Translate: 4\n");

            Console.Write("Выберите команду от 1 до 4: ");
            var command = Console.ReadLine();

            if (command == "1")
            {
                Console.Write("Введите слово на русском языке: ");
                string word = Console.ReadLine();
                if (translator.ContainsKey(word))
                {   
                    Console.WriteLine("Перевод уже есть)");
                }
                else
                {
                    Console.Write("Введите перевод на английском языке: ");
                    string translation = Console.ReadLine();
                    translator.Add(word, translation);
                    Console.WriteLine("Перевод добавлен!\n");
                }
            }
            else if (command == "2")
            {
                Console.Write("Введите слово на русском языке чтобы его удалить: ");
                string word = Console.ReadLine();

                if (translator.ContainsKey(word))
                {
                    translator.Remove(word);
                    Console.WriteLine("Перевод на русском языке был удален(\n");
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "3")
            {
                Console.Write("Введите слово на русском языке чтобы его изменить: ");
                string word = Console.ReadLine();

                if (translator.ContainsKey(word))
                {
                    Console.WriteLine("Введите измененный пеервод на англисуом языке");
                    string NewTranslation = Console.ReadLine();

                    translator[word] = NewTranslation;
                    Console.WriteLine("Измененный перевод был добавлен!\n");
                    
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "4")
            {
                Console.Write("Введите слово на русском языке: ");
                string word = Console.ReadLine();

                if (translator.ContainsKey(word))
                {
                    Console.WriteLine("Перевод на английский языкк: " + translator[word]);
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else
            {
                Console.WriteLine("Неправильная команда(");
                Console.WriteLine("Вы должны ввести числа от 1 до 4 :D\n");
            }
        }

    }
}