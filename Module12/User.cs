namespace Module12;

/// <summary>
/// Класс, описывающий пользователя
/// </summary>
public class User
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login{ get; set; }

    /// <summary>
    /// Премиальный или нет
    /// </summary>
    public bool IsPremium { get; set; }

    /// <summary>
    /// Конструктор пользователя
    /// </summary>
    /// <param name="name">имя</param>
    /// <param name="login">логин</param>
    /// <param name="is_prem">отметка премиум</param>
    public User(string name, string login, bool is_prem)
    {
        Name = name;
        Login = login;
        IsPremium = is_prem;
    }
}
