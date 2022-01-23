using SolidPrinciples.SingleResponsibility.Broken.Data;

namespace SolidPrinciples.SingleResponsibility.Fixed.Services
{
    internal class EmailService
    {
        //private readonly EmailClient _emailClient;

        public void SendRegistrationEmail(string emailAddress)
        {
            var email = new Email() { ToAddress = emailAddress };
            //_emailClient.SendEmail(email)
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
