namespace Module5.Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInfo = GetUserInfo();
            Console.WriteLine();
            ShowUserInfo(userInfo);
        }

        static void ShowUserInfo((string firstName, string lastName, int age, bool havePet, int countPet, string[] petNames, int colorsCount, string[] favColors) userInfo)
        {
            Console.WriteLine($"Firstname: {userInfo.firstName}");
            Console.WriteLine($"Lastname: {userInfo.lastName}");
            Console.WriteLine($"Age: {userInfo.age}");
            Console.WriteLine($"Have pet: {userInfo.havePet}");
            Console.WriteLine($"Count pet: {userInfo.countPet}");
            foreach (var pet in userInfo.petNames)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine($"Colors count: {userInfo.colorsCount}");
            foreach (var color in userInfo.favColors)
            {
                Console.WriteLine(color);
            }
        }

        static (string firstName, string lastName, int age, bool havePet, int countPet, string[] petNames, int colorsCount, string[] favColors) GetUserInfo()
        {
            Console.Write("Enter firstname: ");
            var name = Console.ReadLine();

            Console.Write("Enter lastname: ");
            var lastname = Console.ReadLine();  

            var age = GetAge();

            Console.Write("Do you have a pet? ");
            var pet = Console.ReadLine();

            bool havePet = false;
            string[] petnames = null;

            var countPet = 0;

            if (pet == "да")
            {
                havePet = true;
                countPet = GetPetsCount();
                petnames = GetPetNames(countPet);
            }

            var favColorsCount = GetFavColorsCount(); 
            var colors = GetFavoriteColors(favColorsCount);

            return (name, lastname, age, havePet, countPet, petnames, favColorsCount, colors);
        }

        static string[] GetPetNames(int petsCount)
        {
            var petnames = new string[petsCount];

            for (int i = 0; i < petsCount; i++)
            {
                Console.Write($"Enter name for {i + 1} pet: ");
                petnames[i] = Console.ReadLine();
            }

            return petnames;
        }

        static string[] GetFavoriteColors(int colorsCount)
        {
            var colors = new string[colorsCount];

            for (int i = 0; i < colorsCount; i++)
            {
                Console.Write($"Enter your {i + 1} color: ");
                colors[i] = Console.ReadLine();
            }

            return colors;
        }

        static int GetAge()
        {
            var age = 0;
            var parseResult = false;

            do
            {
                Console.Write("Enter your age: ");
                parseResult = int.TryParse(Console.ReadLine(), out age);
            }
            while (!parseResult || age < 1);

            return age;
        }

        static int GetPetsCount()
        {
            var petsCount = 0;
            var parseResult = false; 

            do
            {
                Console.Write("Enter count of your pets: ");
                parseResult = int.TryParse(Console.ReadLine(), out petsCount);
            }while (!parseResult || petsCount < 1);

            return petsCount;
        }

        static int GetFavColorsCount()
        {
            var favColorsCount = 0;
            var parseResult = false;

            do
            {
                Console.Write("Enter your colors count: ");
                parseResult = int.TryParse(Console.ReadLine(), out favColorsCount);
            } while (!parseResult ||  favColorsCount < 1);

            return favColorsCount;
        }
    }
}
