using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson10LoginPasword
{
    public class ValidatorInputData
    {
        public static bool ValidateData(string login, string password, string confirmPassword)
        {


            try
            {
                ValidateLogin(login);
                ValidatePassword(password, confirmPassword);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
        }

        public static void ValidateLogin(string login)
        {
            if (login.Length >= 20 || login.Contains(" "))
            {
                throw new WrongLoginException("Логин должен быть меньше 20 символов и не содержать пробелы.");
            }
        }

        public static void ValidatePassword(string password, string confirmPassword)
        {
            if (password.Length >= 20 || password.Contains(" ") || !ContainsDigit(password))
            {
                throw new WrongPasswordException("Пароль должен быть меньше 20 символов, не содержать пробелы и содержать хотя бы одну цифру.");
            }

            if (password != confirmPassword)
            {
                throw new WrongPasswordException("Пароль и подтверждение пароля должны совпадать.");
            }

        }
        public static bool ContainsDigit(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }


    }
    
}
