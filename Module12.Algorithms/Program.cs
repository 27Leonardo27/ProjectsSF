using System.Runtime.CompilerServices;

namespace Module12.Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User()
            {
                Name = "Ivan",
                Login = "Iv228",
                IsPremium = false
            };

            var user2 = new User() 
            {
                Name = "Andrew", 
                Login = "AndromedA", 
                IsPremium = false 
            };

            var user3 = new User() 
            {
                Name = "James",
                Login = "_GoAt_", 
                IsPremium = true 
            };

            Console.WriteLine($"Hello, {user1.Name}");

            if (!user1.IsPremium)
            {
                ShowAds();
            }
            else 
            { 
                Console.WriteLine("Your subscription is active!");
            }

            Console.WriteLine($"Hello, {user2.Name}");

            if (!user2.IsPremium)
            {
                ShowAds();
            }
            else 
            {
                Console.WriteLine("Your subscription is active!");
            }

            Console.WriteLine($"Hello, {user3.Name}");

            if (!user3.IsPremium)
            {
                ShowAds();
            }
            else
            {
                Console.WriteLine("Your subscription is active!");
            }

            Console.ReadKey();            
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }

    }   
}
         
