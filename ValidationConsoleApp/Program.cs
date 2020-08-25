using System;
using System.Text.RegularExpressions;

namespace Validation
{
    #region My task for console application
    //  Необходимо реализовать сервис, который должен осуществлять валидацию имени и пароля пользователя(консольное приложение). 
    //  Следует предусмотреть логику, чтобы сервис возвращал положительный ответ, только, если имя пользователя представлено в виде адреса и пароль не содержит специальных символов.

    // виходячи з контексту задачі я не використовував рішнень майкрософт на подобі "IValidatableObject" для повноціних програм, метод "IsValid" викликаю в проекті WebValidation для організації валідації, хоча майкрософт рекомендує використовувати "ASP.NET Identity"
    #endregion
    public class Program
    {
        public static bool IsValid(string login, string password)
        {
            string patternLog = @"^([\w\._]+)@([a-z0-9_\.-]+)\.([a-z\.]{2,3})$";
            string patternPassword = @"^[A-Za-z0-9]{3,60}$";

            return Regex.IsMatch(login, patternLog) && Regex.IsMatch(password, patternPassword);
        }
        static void Main()
        {
            
            Console.WriteLine("Login");
            string inputLog = Console.ReadLine();

            Console.WriteLine("Password");
            string inputPassword = Console.ReadLine();

            // result
            Console.WriteLine(IsValid(inputLog, inputPassword));

            Console.ReadKey();
        }
    }
}
