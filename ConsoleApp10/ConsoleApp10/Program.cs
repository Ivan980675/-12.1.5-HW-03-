class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }

    static void Main(string[] args)
    {
        User user = new User();

        // Ввод информации о пользователе
        Console.Write("Введите логин: ");
        user.Login = Console.ReadLine();

        Console.Write("Введите имя: ");
        user.Name = Console.ReadLine();

        Console.Write("Являетесь ли вы премиум-пользователем? (yes/no): ");
        string premiumInput = Console.ReadLine();
        user.IsPremium = premiumInput.Trim().ToLower() == "yes";

        // Показываем рекламу или отсутствие рекламы
        if (user.IsPremium)
        {
            Console.WriteLine("Вы являетесь премиум-пользователем, реклама отсутствует.");
        }
        else
        {
            ShowAds();
        }
    }
}