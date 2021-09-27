using System;

namespace Laboratorka2
{
    class User

    {

        public string login; // индекс

        public string name;     // Страна

        public string surname;     // город

        public string age;     // улица

        private DateTime date = DateTime.Today; 
        
        
        


        public void GetInfo()

        {           
            Console.WriteLine($"login: {login} \nname: {name} \nsurname: {surname} \nage: {age} \ndate of registrarion: {date.ToString("D")}\n");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            User user = new User();

            user.login = "murenetsnikita@gmail.com";

            user.name = "Nikita";

            user.surname = "Murenets";

            user.age = "18";
                         
            user.GetInfo();  

            Console.ReadKey();

        }

    }
}
