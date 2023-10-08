namespace WPF_WEATHER_APP_AVGUSTIN.Core.Models.User
{
    /// <summary>
    ///  User model
    ///  - контейнер для хранения данных о пользователе
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public User()
        {

        }

        public override string ToString()
        {
            return $"{Name} {Password}";
        }
    }
}
