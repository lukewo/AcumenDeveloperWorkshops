using SolidPrinciples.SingleResponsibility.Broken.Data;

namespace SolidPrinciples.SingleResponsibility.Broken.Services
{
    internal class UserService
    {
        //private readonly EmailClient _emailClient;

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not an email");

            var user = new User() { EmailAddress = email, Password = password };

            SendRegistrationEmail(user.EmailAddress);
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendRegistrationEmail(string emailAddress)
        {
            var email = new Email() { ToAddress = emailAddress };
            //_emailClient.SendEmail(email)
        }
    }
}
