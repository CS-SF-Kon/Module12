namespace Module12;

internal class Program
{
    static void Main(string[] args)
    {
        List<User> users = new() // пробую работу с коллекциями, очень удобно
        {
            new User("Петя", "PitRusha", true),
            new User("Вася", "vasyan228", false),
            new User("Игорь", "ChervIgor", true)
        };

        users.Add(new User("Kolya", "kalumbasik", false)); // почему "users.Add();" отображается тусклым шрифтом?

        List<string> ads = new()
        {
            "сделать бочку. Скидка на бочки только в этом месяце.",
            "мутировать в гидралиска. +10 к скорости передвижения.",
            "оформить премку по цене чашки кофе, чтобы больше не видеть этот бред."
        };

        foreach (var user in users)
        {
            Console.WriteLine($"Здравствуйте, {user.Name}");
            if (!user.IsPremium)
            {
                foreach (string adv in ads)
                {
                    Console.WriteLine($"{user.Name}, попробуйте {adv}");
                }
            } 
            Console.WriteLine();
        }
    }
}
