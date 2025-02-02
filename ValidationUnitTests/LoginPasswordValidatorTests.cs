using System.Reflection.Metadata;
using ConsoleAppLesson10LoginPasword;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;

namespace ValidationUnitTests
{
    public class LoginPasswordValidatorTests
    {
        [Theory]
        [InlineData("dqkdqlqelqwwsdldsmfks")] // Длина >= 20
        [InlineData("MI REK")] // Содержит пробел
        public void ValidateLogin_ShouldThrowWrongLoginException(string login)
        {
            
            Assert.Throws<WrongLoginException>(() => ValidatorInputData.ValidateLogin(login));
        }

        [Theory]
        [InlineData("ValidUser")] // Корректный логин
        [InlineData("123")]   // Корректный логин
        public void ValidateLogin_ShouldNotThrowException(string login)
        {
            var exception = Record.Exception(() => ValidatorInputData.ValidateLogin(login));
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("ELQJELQKHEQWK")] // Нет цифры
        [InlineData("dAFWKHFWUILHFWLHFLWhfhfwLIFHWLUIFHHW")] // Длина >= 20
        [InlineData("213 5")] // Пробел внутри
        [InlineData("123", "312")] // Пароли не совпадают
        public void ValidatePassword_ShouldThrowWrongPasswordException(string password, string confirmPassword = null)
        {
            Assert.Throws<WrongPasswordException>(() => ValidatorInputData.ValidatePassword(password, confirmPassword ?? password));
        }

        [Theory]
        [InlineData("CorrectPass", "CorrectPass")] // Корректный пароль
        [InlineData("P@ssw0rd", "P@ssw0rd")] // Корректный пароль с символами
        public void ValidatePassword_ShouldNotThrowException(string password, string confirmPassword)
        {
            var exception = Record.Exception(() => ValidatorInputData.ValidatePassword(password, confirmPassword));
      
        }
    }
}