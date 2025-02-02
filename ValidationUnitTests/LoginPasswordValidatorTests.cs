using System.Reflection.Metadata;
using ConsoleAppLesson10LoginPasword;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;

namespace ValidationUnitTests
{
    public class LoginPasswordValidatorTests
    {
        [Theory]
        [InlineData("dqkdqlqelqwwsdldsmfks")] // ����� >= 20
        [InlineData("MI REK")] // �������� ������
        public void ValidateLogin_ShouldThrowWrongLoginException(string login)
        {
            
            Assert.Throws<WrongLoginException>(() => ValidatorInputData.ValidateLogin(login));
        }

        [Theory]
        [InlineData("ValidUser")] // ���������� �����
        [InlineData("123")]   // ���������� �����
        public void ValidateLogin_ShouldNotThrowException(string login)
        {
            var exception = Record.Exception(() => ValidatorInputData.ValidateLogin(login));
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("ELQJELQKHEQWK")] // ��� �����
        [InlineData("dAFWKHFWUILHFWLHFLWhfhfwLIFHWLUIFHHW")] // ����� >= 20
        [InlineData("213 5")] // ������ ������
        [InlineData("123", "312")] // ������ �� ���������
        public void ValidatePassword_ShouldThrowWrongPasswordException(string password, string confirmPassword = null)
        {
            Assert.Throws<WrongPasswordException>(() => ValidatorInputData.ValidatePassword(password, confirmPassword ?? password));
        }

        [Theory]
        [InlineData("CorrectPass", "CorrectPass")] // ���������� ������
        [InlineData("P@ssw0rd", "P@ssw0rd")] // ���������� ������ � ���������
        public void ValidatePassword_ShouldNotThrowException(string password, string confirmPassword)
        {
            var exception = Record.Exception(() => ValidatorInputData.ValidatePassword(password, confirmPassword));
      
        }
    }
}