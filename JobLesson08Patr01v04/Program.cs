using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLesson08Patr01v04
{
    internal class Program
    {
        //Создать консольное приложение, 
        //которое при старте выводит приветствие,
        //записанное в настройках приложения(application-scope). 
        //Запросить у пользователя имя, возраст и род деятельности,
        //а затем сохранить данные в настройках.
        //При следующем запуске отобразить эти сведения.Задать приложению версию и описание.
        static void Main(string[] args)
        {
            Console.WriteLine($"{Properties.Settings.Default.Welcome}");
            if (Properties.Settings.Default.Name != null)
            {
                Console.WriteLine($"Внесённое Имя:       {Properties.Settings.Default.Name}");
                Console.WriteLine($"Внесённый возраст:   {Properties.Settings.Default.Age}");
                Console.WriteLine($"Внесённая профессия: {Properties.Settings.Default.Professon}");
            }

            Console.WriteLine("Введите имя пользователя");
            Properties.Settings.Default.Name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя");
            Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите профессию пользователя");
            Properties.Settings.Default.Professon = Console.ReadLine();
            Properties.Settings.Default.Save();

            Console.ReadLine();
        }
    }
}
