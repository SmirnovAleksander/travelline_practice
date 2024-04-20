public class Program
{

    static Dictionary<string, Action> commands = new Dictionary<string, Action>();

    static Dictionary<string, string> ruseng = new Dictionary<string, string>();
    static Dictionary<string, string> engrus = new Dictionary<string, string>();

    public static void Main(string[] args)
    {
        while (true)
        { 
            InitComand();

            while (true)
            {
                ComandsMenu();

                var command = Console.ReadLine();

                if (commands.ContainsKey(command))
                {
                    commands[command]();
                }
                else
                {
                    Console.WriteLine("Неправильная команда(");
                    Console.WriteLine("Вы должны ввести числа от 1 до 9 :D\n");
                }
            }
        }
    }
    private static void ComandsMenu()
    {

        Console.Write("""
                            ### Список команд ###
                            AddTranslation Russia to English: 1
                            AddTranslation English to Russia: 2
                            RemoveTranslation Russia to English: 3
                            RemoveTranslation English to Russia: 4
                            ChangeTranslation Russia to English: 5
                            ChangeTranslation English to Russia: 6
                            Translate To English: 7
                            Translate To Russia: 8
                            End Program: 9

                            Выберите команду от 1 до 9: 
                            """);
    }

    private static void InitComand()
    {
        commands.Add("1", AddTranslationRusToEng);
        commands.Add("2", AddTranslationEngToRus);
        commands.Add("3", RemoveTranslationRusToEng);
        commands.Add("4", RemoveTranslationEngToRus);
        commands.Add("5", ChangeTranslationRusToEng);
        commands.Add("6", ChangeTranslationEngToRus);
        commands.Add("7", TranslateToEnglish);
        commands.Add("8", TranslateToRussian);
        commands.Add("9", () => { 
            Console.WriteLine("Программа завершена"); 
            Environment.Exit(0); 
        });
    }
    private static void AddTranslationRusToEng()
    {
        Console.Write("Введите слово на русском языке: ");
        string wordRus = Console.ReadLine();

        if (ruseng.ContainsKey(wordRus))
        {
            Console.WriteLine("Перевод уже есть)");
        }
        else
        {
            Console.Write("Введите перевод на английском языке: ");
            string translation = Console.ReadLine();
            ruseng.Add(wordRus, translation);
            Console.WriteLine("Перевод добавлен!\n");
        }
    }
    private static void AddTranslationEngToRus()
    {
        Console.Write("Введите слово на английском языке: ");
        string wordEng = Console.ReadLine();

        if (engrus.ContainsKey(wordEng))
        {
            Console.WriteLine("Перевод уже есть)");
        }
        else
        {
            Console.Write("Введите перевод на русском языке: ");
            string translation = Console.ReadLine();
            engrus.Add(wordEng, translation);
            Console.WriteLine("Перевод добавлен!\n");
        }
    }

    private static void RemoveTranslationRusToEng()
    {
        Console.Write("Введите слово на русском языке чтобы его удалить: ");
        string wordRus = Console.ReadLine();

        if (ruseng.ContainsKey(wordRus))
        {
            ruseng.Remove(wordRus);
            Console.WriteLine("Перевод на русском языке был удален(\n");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найденн\n");
        }
    }

    private static void RemoveTranslationEngToRus()
    {
        Console.Write("Введите слово на английском языке чтобы его удалить: ");
        string wordRus = Console.ReadLine();

        if (ruseng.ContainsKey(wordRus))
        {
            ruseng.Remove(wordRus);
            Console.WriteLine("Перевод на английском языке был удален(\n");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найденн\n");
        }
    }
    private static void ChangeTranslationRusToEng()
    {
        Console.Write("Введите слово на русском языке чтобы его изменить: ");
        string wordRus = Console.ReadLine();

        if (ruseng.ContainsKey(wordRus))
        {
            Console.WriteLine("Введите измененный перевод на английском языке");
            string newTranslation = Console.ReadLine();

            ruseng[wordRus] = newTranslation;
            Console.WriteLine("Измененный перевод был добавлен!\n");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найден\n");
        }
    }

    private static void ChangeTranslationEngToRus()
    {
        Console.Write("Введите слово на английском языке чтобы его изменить: ");
        string wordEng = Console.ReadLine();

        if (engrus.ContainsKey(wordEng))
        {
            Console.WriteLine("Введите измененный перевод на русском языке");
            string newTranslation = Console.ReadLine();

            engrus[wordEng] = newTranslation;
            Console.WriteLine("Измененный перевод был добавлен!\n");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найден\n");
        }
    }

    private static void TranslateToEnglish()
    {
        Console.Write("Введите слово на русском языке: ");
        string wordRus = Console.ReadLine();

        if (ruseng.ContainsKey(wordRus))
        {
            Console.WriteLine($"Перевод на английский язык: {ruseng[wordRus]}");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найден\n");
        }
    }

    private static void TranslateToRussian()
    {
        Console.Write("Введите слово на английском языке: ");
        string wordEng = Console.ReadLine();

        if (engrus.ContainsKey(wordEng))
        {
            Console.WriteLine($"Перевод на русский язык: {engrus[wordEng]}");
        }
        else
        {
            Console.WriteLine("Перевод такого слова не был найден\n");
        }
    }

}