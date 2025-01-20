namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new OldUserDirector();

            // Создаём AdminUser

            IUser AdminUser = new AdminUser();
            User Admin_User = director.Build(AdminUser);
            Console.WriteLine($"AdminUser User: {Admin_User}");

            // Создаём LittleUser
            IUser LittleUser = new LittleUser();
            User Little_User = director.Build(LittleUser);
            Console.WriteLine($"LittleUser User: {Little_User} ");


            Console.ReadLine();
        }
    }
}
