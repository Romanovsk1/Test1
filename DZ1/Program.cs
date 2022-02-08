using System;


namespace DZ1
{
    internal class Program
    {
         
         
        
        static void Main()
        {
           
            Console.WriteLine($"Здравствуйте, как вас зовут? "); // Приветствия + вопрос о имени
            string name = Console.ReadLine(); //Ввод пользователем имени
            Console.WriteLine($"Привет, {name} сегодня " + DateTime.Now); //Вывод имени + нынешней даты)
         
        }
    }
}
