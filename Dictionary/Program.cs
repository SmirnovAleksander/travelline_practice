public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> RusToEng = new Dictionary<string, string>();
        Dictionary<string, string> EngToRus = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("### Список команд ###\n");
            Console.WriteLine("AddTranslation Russia to English: 1 ");
            Console.WriteLine("AddTranslation English to Russia: 2");
            Console.WriteLine("RemoveTranslation Russia to English: 3");
            Console.WriteLine("RemoveTranslation English to Russia: 4");
            Console.WriteLine("ChangeTranslation Russia to English: 5");
            Console.WriteLine("ChangeTranslation English to Russia: 6");
            Console.WriteLine("Translate To English: 7");
            Console.WriteLine("Translate To Russia: 8");
            Console.WriteLine("End Program: 9");

            Console.Write("Выберите команду от 1 до 9: ");
            var command = Console.ReadLine();

            if (command == "1")
            {
                Console.Write("Введите слово на русском языке: ");
                string wordRus = Console.ReadLine();

                if (RusToEng.ContainsKey(wordRus))
                {
                    Console.WriteLine("Перевод уже есть)");
                }
                else
                {
                    Console.Write("Введите перевод на английском языке: ");
                    string translation = Console.ReadLine();
                    RusToEng.Add(wordRus, translation);
                    Console.WriteLine("Перевод добавлен!\n");
                }
            }

            else if (command == "2")
            {
                Console.Write("Введите слово на английском языке: ");
                string wordEng = Console.ReadLine();

                if (EngToRus.ContainsKey(wordEng))
                {
                    Console.WriteLine("Перевод уже есть)");
                }
                else
                {
                    Console.Write("Введите перевод на русском языке: ");
                    string translation = Console.ReadLine();
                    EngToRus.Add(wordEng, translation);
                    Console.WriteLine("Перевод добавлен!\n");
                }
            }
            else if (command == "3")
            {
                Console.Write("Введите слово на русском языке чтобы его удалить: ");
                string wordRus = Console.ReadLine();

                if (RusToEng.ContainsKey(wordRus))
                {
                    RusToEng.Remove(wordRus);
                    Console.WriteLine("Перевод на русском языке был удален(\n");
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "4")
            {
                Console.Write("Введите слово на английском языке чтобы его удалить: ");
                string wordRus = Console.ReadLine();

                if (RusToEng.ContainsKey(wordRus))
                {
                    RusToEng.Remove(wordRus);
                    Console.WriteLine("Перевод на английском языке был удален(\n");
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }

            else if (command == "5")
            {
                Console.Write("Введите слово на русском языке чтобы его изменить: ");
                string wordRus = Console.ReadLine();

                if (RusToEng.ContainsKey(wordRus))
                {
                    Console.WriteLine("Введите измененный пеервод на англисуом языке");
                    string NewTranslation = Console.ReadLine();

                    RusToEng[wordRus] = NewTranslation;
                    Console.WriteLine("Измененный перевод был добавлен!\n");

                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "6")
            {
                Console.Write("Введите слово на английском языке чтобы его изменить: ");
                string wordEng = Console.ReadLine();

                if (EngToRus.ContainsKey(wordEng))
                {
                    Console.WriteLine("Введите измененный пеервод на русском языке");
                    string NewTranslation = Console.ReadLine();

                    EngToRus[wordEng] = NewTranslation;
                    Console.WriteLine("Измененный перевод был добавлен!\n");

                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "7")
            {
                Console.Write("Введите слово на русском языке: ");
                string wordRus = Console.ReadLine();

                if (RusToEng.ContainsKey(wordRus))
                {
                    Console.WriteLine("Перевод на английский языкк: " + RusToEng[wordRus]);
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "8")
            {
                Console.Write("Введите слово на английском языке: ");
                string wordEng = Console.ReadLine();

                if (EngToRus.ContainsKey(wordEng))
                {
                    Console.WriteLine("Перевод на русский языкк: " + EngToRus[wordEng]);
                }
                else
                {
                    Console.WriteLine("Перевод такого слова не был найденн\n");
                }
            }
            else if (command == "9")
            {
                Console.WriteLine("Программа завершена");
                break;
            }
            else
            {
                Console.WriteLine("Неправильная команда(");
                Console.WriteLine("Вы должны ввести числа от 1 до 9 :D\n");
            }
        }
    }
}